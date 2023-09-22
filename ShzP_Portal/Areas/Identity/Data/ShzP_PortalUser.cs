using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Identity;

namespace ShzP_Portal.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ShzP_PortalUser class
public class ShzP_PortalUser : IdentityUser
{
    [PersonalData]
    public string FirstName { get; set; }

    [PersonalData]
    public string LastName { get; set; }

    [PersonalData]
    //[Display(Name = "Profile Picture")]
    public string? ProfilePicturePath { get; set; }
}

