using System;
using System.Linq;
using System.Net.Security;
using Agile.Now.ApiOrganizations.Model;

namespace Agile.Now.ApiOrganizations.Test.Api;

internal static class TestDepartmentData
{
    public static int[] TestUsers = new[] { 35012, 34967 };

    public static DepartmentInsertData CreateDepartmentData(string suffix = null)
    {
        var name = "unit-test-department" + suffix;
        var uniqueName = $"{name}-{DateTime.Now:yyyy-MM-dd-HH-mm-ss-fff}";
        return new
        (
            name: uniqueName,
            departmentTypeId: EnumDepartmentType.Internal,
            parentDepartmentId: new("Id", null),
            contactName: name,
            contactEmail: name + "@agilenow.io"
        )
        {
            CountryId = EnumCountry.FIN,
            Level = 1,
            IsActive = true
        };
    }

    public static DepartmentInsertData[] CreateDepartmentDataList(int count) =>
        Enumerable.Range(0, count).Select(i => CreateDepartmentData(i.ToString())).ToArray();

    public static void UpdateDepartmentData(DepartmentInsertData departmentInsertData, string id = null)
    {
        if (id != null)
            departmentInsertData.Id = id;
        const string updated = "updated";
        departmentInsertData.Name += updated;
        departmentInsertData.DepartmentTypeId =
            departmentInsertData.DepartmentTypeId == EnumDepartmentType.Internal ?
                EnumDepartmentType.External : EnumDepartmentType.Internal;
        departmentInsertData.CountryId = departmentInsertData.CountryId == EnumCountry.FIN ?
            EnumCountry.USA : EnumCountry.FIN;
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
