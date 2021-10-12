using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Chefs.Models
{

        public class Chef
        {
            [Key]
            public int ChefId {get;set;}
            public string FirstName {get;set;}
            public string LastName {get;set;}

            public DateTime Date {get;set;}
            public string Email {get;set;}
            // Navigation property for related Recipie objects
            public List<Recipie> CreatedRecipies {get;set;}
            
        }
        public class Recipie
        {
            [Key]
            public int RecipieId {get;set;}
            public string DishName {get;set;}

            public int Calories {get;set;}
            public int Tastiness {get;set;}
            public string Description {get;set;}
            public int ChefId {get;set;}
            // Navigation property for related Chef object
            public Chef Creator {get;set;}
        }
}