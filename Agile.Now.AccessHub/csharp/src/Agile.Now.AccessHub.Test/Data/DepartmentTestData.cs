using System.Linq;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Data;

namespace Agile.Now.ApiOrganizations.Test.Api;

internal static class DepartmentTestData
{
    public static string[] Departments = new[] { "2E97527D-5BD7-4CC0-81B8-14B6C2CA325F" };

    public static DepartmentInsertData CreateDepartmentData(string suffix = null)
    {
        var name = CommonTestData.NamePrefix + "department" + suffix;
        return new DepartmentInsertData
        (
            name: name.MakeUnique(),
            departmentTypeId: EnumDepartmentType.Internal,
            parentDepartmentId: new("Id", ""),
            contactEmail: name + "@agilenow.io",
            contactName: name,
            countryId: EnumCountry.Finland
        );
    }

    public static void UpdateDepartmentData(DepartmentInsertData departmentInsertData)
    {
        departmentInsertData.ContactName = departmentInsertData.ContactName.MarkUpdated();
        departmentInsertData.ContactEmail = departmentInsertData.ContactEmail.MarkUpdated();
        departmentInsertData.CountryId = departmentInsertData.CountryId == 
            EnumCountry.Finland ? EnumCountry.UnitedStatesOfAmerica : EnumCountry.Finland;
    }

    public static DepartmentUpdateData ToDepartmentUpdateData(this DepartmentInsertData departmentInsertData) =>
        new
        (
            name: departmentInsertData.Name,
            contactName: departmentInsertData.ContactName,
            contactEmail: departmentInsertData.ContactEmail,
            countryId: departmentInsertData.CountryId
        );

    public static DepartmentData ToDepartmentData(this DepartmentInsertData departmentInsertData) =>
        new
        (
            id: departmentInsertData.Id,
            name: departmentInsertData.Name,
            departmentTypeId: departmentInsertData.DepartmentTypeId,
            contactName: departmentInsertData.ContactName,
            contactEmail: departmentInsertData.ContactEmail,
            countryId: departmentInsertData.CountryId
        );
}
