using System;
using System.Collections.Generic;
using System.Linq;
using Agile.Now.AccessHub.Model;
using Agile.Now.Api.Test;
using Xunit;

namespace Agile.Now.AccessHub.Test.Data;

public class Department_TestData : TestData<Department, DepartmentInsertData> {
    public override void AssertEqualToRequest(DepartmentInsertData data0, Department data1) => data0.AssertEqualToRequest(data1);
    public override void AssertEqualToResponse(Department data0, Department data1) => data0.AssertEqualToRequest(data1);
    public override void Update(DepartmentInsertData data) => data.Update();

    public override IEnumerable<DepartmentInsertData> GenerateRequestData() =>
        Enumerable.Range(0, 4).Select(i => {
            var name = CreateTestEntityName("department", i.ToString());
            return new DepartmentInsertData(
                externalId: Guid.NewGuid().ToString(),
                name: name.MakeUnique(),
                departmentTypeId: EnumDepartmentType.Internal,
                parentDepartmentId: new("Id", ""),
                contactEmail: name + "@agilenow.io",
                contactName: name,
                countryId: EnumCountry.Finland
            );
        });
}

public static class DepartmentTestData_Extention {
    public static void Update(this DepartmentInsertData departmentInsertData) {
        departmentInsertData.ContactName = departmentInsertData.ContactName.MarkUpdated();
        departmentInsertData.ContactEmail = departmentInsertData.ContactEmail.MarkUpdated();
        departmentInsertData.CountryId = departmentInsertData.CountryId ==
            EnumCountry.Finland ? EnumCountry.UnitedStatesOfAmerica : EnumCountry.Finland;
    }

    public static void AssertEqualToRequest(this DepartmentInsertData departmentInsertData, Department department) {
        Assert.Equal(departmentInsertData.Name, department.Name);
        Assert.Equal(departmentInsertData.DepartmentTypeId.ToString(), department.DepartmentTypeId.Id);
        Assert.Equal(departmentInsertData.ParentDepartmentId.Value ?? "", department.ParentDepartmentId.Id ?? "");
        Assert.Equal(departmentInsertData.ContactName, department.ContactName);
        Assert.Equal(departmentInsertData.ContactEmail, department.ContactEmail);
        Assert.Equal(departmentInsertData.CountryId, EnumCountryValueConverter.FromString(department.CountryId.Id));
    }

    public static void AssertEqualToRequest(this Department departmentInsertData, Department department) {
        Assert.Equal(departmentInsertData.Name, department.Name);
        Assert.Equal(departmentInsertData.DepartmentTypeId.Id, department.DepartmentTypeId.Id);
        Assert.Equal(departmentInsertData.ParentDepartmentId.Id ?? "", department.ParentDepartmentId.Id ?? "");
        Assert.Equal(departmentInsertData.ContactName, department.ContactName);
        Assert.Equal(departmentInsertData.ContactEmail, department.ContactEmail);
        Assert.Equal(departmentInsertData.CountryId.Id, department.CountryId.Id);
    }

    public static DepartmentUpdateData ToDepartmentUpdateData(this DepartmentInsertData departmentInsertData) => new(
        name: departmentInsertData.Name,
        contactName: departmentInsertData.ContactName,
        contactEmail: departmentInsertData.ContactEmail,
        countryId: departmentInsertData.CountryId
    );

    public static DepartmentData ToDepartmentData(this DepartmentInsertData departmentInsertData) => new(
        id: departmentInsertData.Id,
        name: departmentInsertData.Name,
        parentDepartmentId: departmentInsertData.ParentDepartmentId,
        departmentTypeId: departmentInsertData.DepartmentTypeId,
        contactName: departmentInsertData.ContactName,
        contactEmail: departmentInsertData.ContactEmail,
        countryId: departmentInsertData.CountryId
    );
}
