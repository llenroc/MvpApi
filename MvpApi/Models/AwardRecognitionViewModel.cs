// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

using System;
using Microsoft.Rest;
using Newtonsoft.Json;

namespace MvpApi.Models
{
    public partial class AwardRecognitionViewModel
    {
        /// <summary>
        /// Initializes a new instance of the AwardRecognitionViewModel class.
        /// </summary>
        public AwardRecognitionViewModel() { }

        /// <summary>
        /// Initializes a new instance of the AwardRecognitionViewModel class.
        /// </summary>
        public AwardRecognitionViewModel(string title, DateTime dateEarned, int? privateSiteId = default(int?), string description = default(string), string referenceUrl = default(string), VisibilityViewModel awardRecognitionVisibility = default(VisibilityViewModel))
        {
            PrivateSiteId = privateSiteId;
            Title = title;
            Description = description;
            DateEarned = dateEarned;
            ReferenceUrl = referenceUrl;
            AwardRecognitionVisibility = awardRecognitionVisibility;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PrivateSiteId")]
        public int? PrivateSiteId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DateEarned")]
        public DateTime DateEarned { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ReferenceUrl")]
        public string ReferenceUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AwardRecognitionVisibility")]
        public VisibilityViewModel AwardRecognitionVisibility { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Title == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Title");
            }
            if (this.Title != null)
            {
                if (this.Title.Length > 100)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Title", 100);
                }
                if (this.Title.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Title", 0);
                }
            }
            if (this.Description != null)
            {
                if (this.Description.Length > 2000)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Description", 2000);
                }
                if (this.Description.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Description", 0);
                }
            }
            if (this.ReferenceUrl != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(this.ReferenceUrl, "^((https?|ftp):\\/\\/)?(((([a-zA-Z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(%[\\da-fA-F]{2})|[!\\$&amp;'\\(\\)\\*\\+,;=]|:)*@)?(((\\d|[1-9]\\d|1\\d\\d|2[0-4]\\d|25[0-5])\\.(\\d|[1-9]\\d|1\\d\\d|2[0-4]\\d|25[0-5])\\.(\\d|[1-9]\\d|1\\d\\d|2[0-4]\\d|25[0-5])\\.(\\d|[1-9]\\d|1\\d\\d|2[0-4]\\d|25[0-5]))|((([a-zA-Z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(([a-zA-Z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])([a-zA-Z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])*([a-zA-Z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])))\\.)+(([a-zA-Z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(([a-zA-Z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])([a-zA-Z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])*([a-zA-Z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])))\\.?)(:\\d*)?)(\\/((([a-zA-Z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(%[\\da-fA-F]{2})|[!\\$&amp;'\\(\\)\\*\\+,;=]|:|@)+(\\/(([a-zA-Z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(%[\\da-fA-F]{2})|[!\\$&amp;'\\(\\)\\*\\+,;=]|:|@)*)*)?)?(\\?((([a-zA-Z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(%[\\da-fA-F]{2})|[!\\$&amp;'\\(\\)\\*\\+,;=]|:|@)|[\\uE000-\\uF8FF]|\\/|\\?)*)?(\\#((([a-zA-Z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(%[\\da-fA-F]{2})|[!\\$&amp;'\\(\\)\\*\\+,;=]|:|@)|\\/|\\?)*)?$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "ReferenceUrl", "^((https?|ftp):\\/\\/)?(((([a-zA-Z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(%[\\da-fA-F]{2})|[!\\$&amp;'\\(\\)\\*\\+,;=]|:)*@)?(((\\d|[1-9]\\d|1\\d\\d|2[0-4]\\d|25[0-5])\\.(\\d|[1-9]\\d|1\\d\\d|2[0-4]\\d|25[0-5])\\.(\\d|[1-9]\\d|1\\d\\d|2[0-4]\\d|25[0-5])\\.(\\d|[1-9]\\d|1\\d\\d|2[0-4]\\d|25[0-5]))|((([a-zA-Z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(([a-zA-Z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])([a-zA-Z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])*([a-zA-Z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])))\\.)+(([a-zA-Z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(([a-zA-Z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])([a-zA-Z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])*([a-zA-Z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])))\\.?)(:\\d*)?)(\\/((([a-zA-Z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(%[\\da-fA-F]{2})|[!\\$&amp;'\\(\\)\\*\\+,;=]|:|@)+(\\/(([a-zA-Z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(%[\\da-fA-F]{2})|[!\\$&amp;'\\(\\)\\*\\+,;=]|:|@)*)*)?)?(\\?((([a-zA-Z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(%[\\da-fA-F]{2})|[!\\$&amp;'\\(\\)\\*\\+,;=]|:|@)|[\\uE000-\\uF8FF]|\\/|\\?)*)?(\\#((([a-zA-Z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(%[\\da-fA-F]{2})|[!\\$&amp;'\\(\\)\\*\\+,;=]|:|@)|\\/|\\?)*)?$");
                }
            }
        }
    }
}
