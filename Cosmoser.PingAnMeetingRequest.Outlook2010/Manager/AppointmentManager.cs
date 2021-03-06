﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Outlook = Microsoft.Office.Interop.Outlook;
using Cosmoser.PingAnMeetingRequest.Common.Model;
using Cosmoser.PingAnMeetingRequest.Common.Utilities;
using log4net;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows;

namespace Cosmoser.PingAnMeetingRequest.Outlook2010.Manager
{
    public class AppointmentManager
    {
        private static string path = "http://schemas.microsoft.com/mapi/string/{71227b02-8acf-4f1f-9a89-40fb98cfaa1c}/";
        private static ILog logger = IosLogManager.GetLogger(typeof(AppointmentManager));
        
        public string GetMeetingIdFromAppointment(Outlook.AppointmentItem item)
        {
            string meetingId = null;
            try
            {
                meetingId = item.PropertyAccessor.GetProperty(path + "PingAnMeetingId");
            }
            catch { }

            SVCMMeetingDetail detail = this.GetMeetingFromAppointment(item, false);

            if (!string.IsNullOrEmpty(meetingId))
                return meetingId;
            else if (detail != null && string.IsNullOrEmpty(detail.Id))
                return detail.Id;
            else
                return null;
        }

        public void SaveMeetingToAppointment(SVCMMeetingDetail meeting, Outlook.AppointmentItem item, bool isUpdating)
        {
            try
            {
                if (isUpdating)
                {

                    item.PropertyAccessor.SetProperty(path + "PingAnMeetingUpdating", Toolbox.Serialize(meeting));
                }
                else
                {

                    item.PropertyAccessor.SetProperty(path + "PingAnMeeting", Toolbox.Serialize(meeting));
                }

                if (!string.IsNullOrEmpty(meeting.Id))
                {
                    item.PropertyAccessor.SetProperty(path + "PingAnMeetingId", meeting.Id);
                }
            }
            catch (Exception ex)
            {
                logger.Error("SaveMeetingToAppointment failed", ex);
            }

        }

        public void RemoveUpdatingMeetingFromAppt(Outlook.AppointmentItem item)
        {
            try
            {
                item.PropertyAccessor.DeleteProperty(path + "PingAnMeetingUpdating");

            }
            catch
            {
                //it is a new appointment
            }
        }

        public SVCMMeetingDetail GetMeetingFromAppointment(Outlook.AppointmentItem item, bool isUpdating)
        {
            try
            {
                SVCMMeetingDetail detail;
                if (isUpdating)
                {
                    detail = Toolbox.Deserialize<SVCMMeetingDetail>(item.PropertyAccessor.GetProperty(path + "PingAnMeetingUpdating"));
                }
                else
                {
                    detail = Toolbox.Deserialize<SVCMMeetingDetail>(item.PropertyAccessor.GetProperty(path + "PingAnMeeting"));
                }

                return detail;

            }
            catch
            {
                //it is a new appointment
            }

            return null;
        }

        public void SetAppointmentDeleted(Outlook.AppointmentItem item, bool isDeleted)
        {
            try
            {
                item.PropertyAccessor.SetProperty(path + "IsDeleted", isDeleted.ToString());
            }
            catch(Exception ex)
            {
                logger.Error("SetAppointmentDeleted failed", ex);
            }
        }

        public bool IsAppointmentStatusDeleted(Outlook.AppointmentItem item)
        {
            try
            {
                return bool.Parse(item.PropertyAccessor.GetProperty(path + "IsDeleted"));
            }
            catch
            {
                //it is a new appointment
            }

            return false;
        }

        public void RemoveItemDeleteStatus(Outlook.AppointmentItem item)
        {
            try
            {
                item.PropertyAccessor.DeleteProperty(path + "IsDeleted");

            }
            catch
            {
                //it is a new appointment
            }
        }

        internal bool TryValidateApppointmentUIInput(SVCMMeetingDetail meeting, out string message)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                //var meeting = this.GetMeetingFromAppointment(item, true);

                if (meeting != null)
                {
                    if(meeting.EndTime < meeting.StartTime)
                        sb.AppendLine("会议结束时间不能早于开始时间！");
                    if (meeting.Rooms == null || meeting.Rooms.Count == 0)
                        sb.AppendLine("请至少选择一个会议室！");

                    if (meeting.VideoSet == VideoSet.MainRoom && (meeting.MainRoom == null || string.IsNullOrEmpty(meeting.MainRoom.RoomId)))
                        sb.AppendLine("请设定一个主会场！");

                    if (string.IsNullOrEmpty(meeting.Name))
                        sb.AppendLine("请填写主题（会议名称）！");

                    if (string.IsNullOrEmpty(meeting.Phone))
                        sb.AppendLine("联系电话不能为空！");

                    Regex regex = new Regex("^[0-9]*[1-9][0-9]*$");
                    if (!string.IsNullOrEmpty(meeting.Phone) && !regex.IsMatch(meeting.Phone))
                        sb.AppendLine("联系电话只能输入为数字!");

                    if (meeting.ParticipatorNumber < 1)
                        sb.AppendLine("请填写参会人数，并且大于0！");

                    if (meeting.ConfMideaType == MideaType.Video && meeting.Rooms != null && meeting.Rooms.Count == 1 && string.IsNullOrEmpty(meeting.IPDesc))
                        sb.AppendLine("预订视频会议，至少需要两方会场。请增加IP电话，或者增加会议室!");

                    if (meeting.ConfMideaType == MideaType.Local && !string.IsNullOrWhiteSpace(meeting.IPDesc))
                    {
                        sb.AppendLine("预约本地会议不能选择ip电话参会!");
                    }

                    if(meeting.Memo.Length > 200)
                        sb.AppendLine("会议备注长度不能超过200个字符或100个汉字！");

                    //if (meeting.Memo.Contains("&") || meeting.Memo.Contains("^"))
                    //    sb.AppendLine("会议备注不能包含特殊字符，如&，^ 等");

                    if (meeting.ConfMideaType == MideaType.Video && !string.IsNullOrWhiteSpace(meeting.IPDesc))
                    {
                        var array = meeting.IPDesc.Split(" ".ToArray());
                        foreach (var item in array)
                        {
                            if (item.Trim().Length > 0 && item.Trim().Length != 6)
                            {
                                sb.AppendLine("ip电话长度必须为6位数!");
                                break;
                            }
                        }
                    }                   
                }
                else
                {
                    //meeting = //this.GetMeetingFromAppointment(item, false);
                    if (meeting == null)
                    {
                        sb.AppendLine("会议参数异常，请重试！");
                        logger.Error("TryValidateApppointmentUIInput, can find meeting!");
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error("TryValidateApppointmentUIInput failed", ex);
                sb.AppendLine(ex.Message);
            }

            message = sb.ToString();

            if (sb.Length > 0)
                return false;
            return true;
        }

        internal Outlook.AppointmentItem AddAppointment(Outlook.MAPIFolder mAPIFolder, SVCMMeetingDetail detail)
        {
            try
            {
                Outlook.AppointmentItem item = mAPIFolder.Application.CreateItem(Outlook.OlItemType.olAppointmentItem);
                item.Subject = detail.Name;
                item.Start = detail.StartTime;
                item.End = detail.EndTime;
                item.MessageClass = "IPM.Appointment.PingAnMeetingRequest";

                this.SaveMeetingToAppointment(detail, item, false);
                item.Save();

                return item;
            }
            catch (Exception ex)
            {
                logger.Error("AddAppointment failed", ex);
            }

            return null;
        }

        public void AppointmentSendMeeting(Outlook.AppointmentItem item)
        {
            Outlook._AppointmentItem appt = (Outlook._AppointmentItem)item;
           
            appt.MeetingStatus = Outlook.OlMeetingStatus.olMeeting;            

            appt.ForceUpdateToAllAttendees = true;
            Outlook.Recipient recipient = null;

            try
            {
                if (appt.Recipients.Count == 0)
                {
                    MessageBox.Show(string.Format("没有收件人，请设置收件人！"));
                    return;
                }

                foreach (var r in appt.Recipients)
                {
                    recipient = (Outlook.Recipient)r;
                    recipient.Resolve();
                    string email = recipient.Address;
                    if (string.IsNullOrEmpty(email))
                    {
                        MessageBox.Show(string.Format("收件人{0}不能识别，请修正！", recipient.Name));
                        return;
                    }

                    Marshal.ReleaseComObject(recipient);
                }

                appt.Send();

            }
            catch (Exception ex)
            {
                logger.Error("send meeting failed.", ex);
                if (recipient != null)
                    Marshal.ReleaseComObject(recipient);
            }
        }

        public bool ResolveRecipients(Outlook.AppointmentItem item, out string message)
        {
            message = string.Empty;

            Outlook._AppointmentItem appt = (Outlook._AppointmentItem)item;           

            appt.ForceUpdateToAllAttendees = true;
            Outlook.Recipient recipient = null;

            try
            {
                if (appt.Recipients.Count == 0)
                {
                    message = "没有收件人，请设置收件人！";
                    return false;
                }

                foreach (var r in appt.Recipients)
                {
                    recipient = (Outlook.Recipient)r;
                    recipient.Resolve();
                    string email = recipient.Address;
                    if (string.IsNullOrEmpty(email))
                    {
                        message = string.Format("收件人{0}不能识别，请修正！", recipient.Name);
                        return false;
                    }

                    Marshal.ReleaseComObject(recipient);
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }

            return true;
        }
    }
}
