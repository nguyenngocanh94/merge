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
        public bool? LoadFormLayoutFramework { get; set; }
        public bool? FormLayoutAutogenerate { get; set; }
        public bool DisableSubmitButton { get; set; }
        public bool RemoveCaptchaLogged { get; set; }
        public string Css { get; set; }
        public string Js { get; set; }
        public string FormTitle { get; set; }
        public bool? ShowFormTitle { get; set; }
        public bool? Published { get; set; }
        public string Lang { get; set; }
        public string ReturnUrl { get; set; }
        public bool? ShowSystemMessage { get; set; }
        public bool? ShowThankyou { get; set; }
        public bool ScrollToThankYou { get; set; }
        public bool ThankYouMessagePopUp { get; set; }
        public string Thankyou { get; set; }
        public bool? ShowContinue { get; set; }
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
        public bool MetaTitle { get; set; }
        public string MetaDesc { get; set; }
        public string MetaKeywords { get; set; }
        public string Required { get; set; }
        public string ErrorMessage { get; set; }
        public string MultipleSeparator { get; set; }
        public bool? TextareaNewLines { get; set; }
        public string Cssclass { get; set; }
        public string Cssid { get; set; }
        public string Cssname { get; set; }
        public string Cssaction { get; set; }
        public string CssadditionalAttributes { get; set; }
        public bool AjaxValidation { get; set; }
        public bool ScrollToError { get; set; }
        public string ThemeParams { get; set; }
        public bool? Keepdata { get; set; }
        public bool? KeepIp { get; set; }
        public bool Backendmenu { get; set; }
        public bool ConfirmSubmission { get; set; }
        public string Access { get; set; }
    }
}
