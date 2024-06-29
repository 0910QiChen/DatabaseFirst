using DatabaseFirstSite.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace DatabaseFirstSite.Models
{
    [MetadataType(typeof(StudentMetadata))]
    public partial class Student
    {
    }

    [MetadataType(typeof(EnrollmentMetadata))]
    public partial class Enrollment
    {
    }
}