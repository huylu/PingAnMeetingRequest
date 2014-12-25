﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cosmoser.PingAnMeetingRequest.Common.Model;
using Cosmoser.PingAnMeetingRequest.Common.Utilities;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Threading.Tasks;
using Cosmoser.PingAnMeetingRequest.Common.ClientService;
using log4net;

namespace Cosmoser.PingAnMeetingRequest.Outlook2010.Manager
{
    public class CalendarDataManager
    {
        private CalendarFolder _calendarFolder;
        private static string path = "http://schemas.microsoft.com/mapi/string/{71227b02-8acf-4f1f-9a89-40fb98cfaa1c}/";
        private MeetingDetailData _meetingDataLocal = new MeetingDetailData();
        private MeetingData _meetingListServer = new MeetingData();
        private AppointmentManager _appointmentManager;

        static ILog logger = IosLogManager.GetLogger(typeof(CalendarDataManager));

        public MeetingDetailData MeetingDetailDataLocal
        {
            get
            {
                return this._meetingDataLocal;
            }
        }

        public MeetingData MeetingDataServer
        {
            get
            {
                return _meetingListServer;
            }
        }

        public CalendarDataManager(CalendarFolder folder)
        {
            this._calendarFolder = folder;

            this._meetingDataLocal = this.GetMeetingDataFromLocal();

            this._appointmentManager = new AppointmentManager();
        }

        private MeetingDetailData GetMeetingDataFromLocal()
        {
            MeetingDetailData meetingData = null;
            try
            {
                try
                {
                    string caledarDataString = (string)this._calendarFolder.MAPIFolder.PropertyAccessor.GetProperty(path + "PingAnMeeting");
                    meetingData = Toolbox.Deserialize<MeetingDetailData>(caledarDataString);
                }
                catch
                {
                    meetingData = new MeetingDetailData();
                    this._calendarFolder.MAPIFolder.PropertyAccessor.SetProperty(path + "PingAnMeeting", Toolbox.Serialize(meetingData));
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message + ex.StackTrace);
            }

            return meetingData;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="calendarFolder"></param>
        /// <param name="meetingData"></param>
        public void SavaMeetingDataToCalendarFolder()
        {
            string dataString = Toolbox.Serialize(this._meetingDataLocal);
            this._calendarFolder.MAPIFolder.PropertyAccessor.SetProperty(path + "PingAnMeeting", dataString);
        }

        public void SyncMeetingList()
        {
            //Task<MeetingData> task = GetMeetingListSyncTask();

            ////task.Start();

            //task.Wait();
            Func<MeetingData> func = LoadMeetingdataFromServer;

            Task.Factory.FromAsync<MeetingData>(func.BeginInvoke, func.EndInvoke, null).ContinueWith((result) =>
            {
                this._meetingListServer = result.Result;

                foreach (var item in this._meetingListServer.Values)
                {
                    if ((!this._calendarFolder.AppointmentCollection.ContainsKey(item.Id)))
                    {
                        SVCMMeetingDetail detail = this.ConvertDetail(item);

                        var appt = this._appointmentManager.AddAppointment(this._calendarFolder.MAPIFolder, detail);

                        if (!this.MeetingDetailDataLocal.ContainsKey(item.Id))
                            this.MeetingDetailDataLocal.Add(detail.Id, detail);

                        if (!this._calendarFolder.AppointmentCollection.ContainsKey(item.Id))
                        {
                            this._calendarFolder.AppointmentCollection.Add(item.Id, appt);
                        }
                    }
                }
            });

        }

        private SVCMMeetingDetail ConvertDetail(SVCMMeeting item)
        {
            var detail = new SVCMMeetingDetail();
            detail.Id = item.Id;
            detail.StartTime = item.StartTime;
            detail.EndTime = item.EndTime;
            detail.Name = item.Name;
            detail.Password = item.Password;

            return detail;
        }

        /// <summary>
        /// 获取一个异步同步会议列表任务
        /// </summary>
        /// <returns></returns>
        public Task<MeetingData> GetMeetingListSyncTask()
        {
            return Task<MeetingData>.Factory.StartNew(() =>
            {
                MeetingListQuery query = new MeetingListQuery();

                query.Alias = string.Empty;
                query.ConferenceProperty = string.Empty;
                query.ConfType = "-1";
                query.MeetingName = string.Empty;
                query.RoomName = string.Empty;
                query.ServiceKey = string.Empty;
                query.StartTime = DateTime.Now;
                query.EndTime = DateTime.Now.AddMonths(2);
                query.StatVideoType = -1;

                List<SVCMMeeting> list;
                MeetingData meetingData = new MeetingData();
                bool succeed = ClientServiceFactory.Create().TryGetMeetingList(query, OutlookFacade.Instance().Session, out list);

                if (succeed)
                {
                    foreach (var item in list)
                    {
                        meetingData.Add(item.Id, item);
                    }
                }

                return meetingData;
            });
        }

        /// <summary>
        /// 获取默认会议列表
        /// </summary>
        /// <returns></returns>
        public MeetingData LoadMeetingdataFromServer()
        {
            MeetingListQuery query = new MeetingListQuery();

            query.Alias = string.Empty;
            query.ConferenceProperty = string.Empty;
            query.ConfType = "-1";
            query.MeetingName = string.Empty;
            query.RoomName = string.Empty;
            query.ServiceKey = string.Empty;
            query.StartTime = DateTime.Now;
            query.EndTime = DateTime.Now.AddMonths(2);
            query.StatVideoType = -1;

            List<SVCMMeeting> list;
            MeetingData meetingData = new MeetingData();
            bool succeed = ClientServiceFactory.Create().TryGetMeetingList(query, OutlookFacade.Instance().Session, out list);

            if (succeed)
            {
                foreach (var item in list)
                {
                    meetingData.Add(item.Id, item);
                }
            }

            return meetingData;
        }
            
    }
}
