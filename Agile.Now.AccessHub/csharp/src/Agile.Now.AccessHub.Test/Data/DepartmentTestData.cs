using System;
using System.Collections.Generic;
using System.Linq;
using Agile.Now.AccessHub.Model;
using Agile.Now.AccessHub.Test.Data;
using Xunit;

namespace Agile.Now.ApiOrganizations.Test.Api;

internal static class DepartmentTestData {
    public static DepartmentInsertData CreateDepartmentData(string suffix = null) {
        var name = CommonTestData.CreateTestEntityName("department", suffix);
        return new DepartmentInsertData
        (
            externalId: Guid.NewGuid().ToString(),
            name: name.MakeUnique(),
            departmentTypeId: EnumDepartmentType.Internal,
            parentDepartmentId: new("Id", ""),
            contactEmail: name + "@agilenow.io",
            contactName: name,
            countryId: EnumCountry.Finland
        );
    }

    public static IEnumerable<DepartmentInsertData> CreateDepartmentDatas() =>
        Enumerable.Range(0, 4).Select(i => CreateDepartmentData(i.ToString()));

    public static void Update(this DepartmentInsertData departmentInsertData) {
        departmentInsertData.ContactName = departmentInsertData.ContactName.MarkUpdated();
        departmentInsertData.ContactEmail = departmentInsertData.ContactEmail.MarkUpdated();
        departmentInsertData.CountryId = departmentInsertData.CountryId ==
            EnumCountry.Finland ? EnumCountry.UnitedStatesOfAmerica : EnumCountry.Finland;
    }

    public static void AssertEqual(this DepartmentInsertData departmentInsertData, Department department) {
        Assert.Equal(departmentInsertData.Name, department.Name);
        Assert.Equal(departmentInsertData.DepartmentTypeId.ToString(), department.DepartmentTypeId.Id);
        Assert.Equal(departmentInsertData.ParentDepartmentId.Value ?? "", department.ParentDepartmentId.Id ?? "");
        Assert.Equal(departmentInsertData.ContactName, department.ContactName);
        Assert.Equal(departmentInsertData.ContactEmail, department.ContactEmail);
        Assert.Equal(departmentInsertData.CountryId, EnumCountryValueConverter.FromString(department.CountryId.Id));
    }

    public static void AssertEqual(this Department departmentInsertData, Department department) {
        Assert.Equal(departmentInsertData.Name, department.Name);
        Assert.Equal(departmentInsertData.DepartmentTypeId.ToString(), department.DepartmentTypeId.Id);
        Assert.Equal(departmentInsertData.ParentDepartmentId.Id ?? "", department.ParentDepartmentId.Id ?? "");
        Assert.Equal(departmentInsertData.ContactName, department.ContactName);
        Assert.Equal(departmentInsertData.ContactEmail, department.ContactEmail);
        Assert.Equal(departmentInsertData.CountryId.Id, department.CountryId.Id);
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
