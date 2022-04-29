using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practice_7.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Пожалуйста, введите свое имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите email")]
        [RegularExpression(@"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$", ErrorMessage = "Вы ввели некорректный email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите телефон")]
        [RegularExpression(@"^((8|\+7)[\-]?)?(\(?\d{3}\)?[\-]?)?[\d\-]{7,10}$", ErrorMessage = "Вы ввели некорректный телефон")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Пожалуйста, укажите, примите ли участие в вечеринке")]
        public bool? WillAttend { get; set; }
    }
}