using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosRsformForm
    {
        public int FormId { get; set; }
        public string FormName { get; set; }
        public string FormLayout { get; set; }
        public string FormLayoutName { get; set; }
        public int? LoadFormLayoutFramework { get; set; }
        public int? FormLayoutAutogenerate { get; set; }
        public int DisableSubmitButton { get; set; }
        public int RemoveCaptchaLogged { get; set; }
        public string Css { get; set; }
        public string Js { get; set; }
        public string FormTitle { get; set; }
        public int? ShowFormTitle { get; set; }
        public int? Published { get; set; }
        public string Lang { get; set; }
        public string ReturnUrl { get; set; }
        public int? ShowSystemMessage { get; set; }
        public int? ShowThankyou { get; set; }
        public int ScrollToThankYou { get; set; }
        public int ThankYouMessagePopUp { get; set; }
        public string Thankyou { get; set; }
        public int? ShowContinue { get; set; }
        public string UserEmailText { get; set; }
        public string UserEmailTo { get; set; }
        public string UserEmailCc { get; set; }
        public string UserEmailBcc { get; set; }
        public string UserEmailFrom { get; set; }
        public string UserEmailReplyTo { get; set; }
        public string UserEmailFromName { get; set; }
        public string UserEmailSubject { get; set; }
        public sbyte UserEmailMode { get; set; }
        public sbyte UserEmailAttach { get; set; }
        public string UserEmailAttachFile { get; set; }
        public string AdminEmailText { get; set; }
        public string AdminEmailTo { get; set; }
        public string AdminEmailCc { get; set; }
        public string AdminEmailBcc { get; set; }
        public string AdminEmailFrom { get; set; }
        public string AdminEmailReplyTo { get; set; }
        public string AdminEmailFromName { get; set; }
        public string AdminEmailSubject { get; set; }
        public sbyte AdminEmailMode { get; set; }
        public string ScriptProcess { get; set; }
        public string ScriptProcess2 { get; set; }
        public string ScriptDisplay { get; set; }
        public string UserEmailScript { get; set; }
        public string AdminEmailScript { get; set; }
        public string AdditionalEmailsScript { get; set; }
        public int MetaTitle { get; set; }
        public string MetaDesc { get; set; }
        public string MetaKeywords { get; set; }
        public string Required { get; set; }
        public string ErrorMessage { get; set; }
        public string MultipleSeparator { get; set; }
        public int? TextareaNewLines { get; set; }
        public string Cssclass { get; set; }
        public string Cssid { get; set; }
        public string Cssname { get; set; }
        public string Cssaction { get; set; }
        public string CssadditionalAttributes { get; set; }
        public int AjaxValidation { get; set; }
        public int ScrollToError { get; set; }
        public string ThemeParams { get; set; }
        public int? Keepdata { get; set; }
        public int? KeepIp { get; set; }
        public int Backendmenu { get; set; }
        public int ConfirmSubmission { get; set; }
        public string Access { get; set; }
    }
}
