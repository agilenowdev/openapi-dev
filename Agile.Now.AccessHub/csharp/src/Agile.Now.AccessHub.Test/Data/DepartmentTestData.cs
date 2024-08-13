using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Data;

namespace Agile.Now.ApiOrganizations.Test.Api;

internal static class DepartmentTestData
{
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
        new DepartmentUpdateData 
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
            parentDepartmentId: departmentInsertData.ParentDepartmentId,    
            departmentTypeId: departmentInsertData.DepartmentTypeId,
            contactName: departmentInsertData.ContactName,
            contactEmail: departmentInsertData.ContactEmail,
            countryId: departmentInsertData.CountryId
        );
}
