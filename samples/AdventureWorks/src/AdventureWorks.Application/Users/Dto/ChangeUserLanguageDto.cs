using System.ComponentModel.DataAnnotations;

namespace AdventureWorks.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}