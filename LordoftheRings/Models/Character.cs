using System;
using System.ComponentModel.DataAnnotations;

namespace LordoftheRings.Models
{
    public class Character
    {
        public Character()
        {
        }

        // C# properties = java attribute and public get and set.
        //private int JavaCatId;

        //public int getJavaCatId()
        //{
        //    return this.JavaCatId;
        //}
        //public void setJavaCatId(int catId)
        //{
        //    this.JavaCatId = catId;
        //}


        // If the name is *class_name*Id
        public int CharacterId { get; set; }


        [Required(ErrorMessage = "All Characters must have a name to Date")]
        public string Name { get; set; }

        // Later, create 1-to-many relationship to Race table
        //public string Race { get; set; }

        public Gender? Gender { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Birth Date")]
        public DateTime? BirthDate { get; set; }

        public string ProfilePicture { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 10)]
        public string Description { get; set; }

        // Ratings..Comments, Reviews
        //public List<Review> Reviews { get; set; }


        public int RaceId { get; set; }
        public Race races { get; set; }
    }

    public enum Gender { Male, Female};

}
