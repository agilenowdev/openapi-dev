using System;
using Agile.Now.ApiOrganizations.Model;

namespace Agile.Now.ApiOrganizations.Test.Api
{
    internal static class TestDepartmentData
    {
        public static DepartmentInsertData CreateDepartmentData(string suffix = null)
        {
            var name = "unit-test-department" + suffix;
            var uniqueName = $"{name}-{DateTime.Now:yyyy-MM-dd-HH-mm-ss-fff}";
            return new
            (
                name: uniqueName,
                departmentTypeId: new("Id", "Internal"),
                parentDepartmentId: new("Id", null),
                contactName: name,
                contactEmail: name + "@agilenow.io"
            )
            { 
                CountryId = new("Name", "Finland")
            };
        }
    }
}
