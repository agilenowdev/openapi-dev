﻿using System.Collections.Generic;
using System.Linq;
using Agile.Now.Api.Test;
using Agile.Now.Runtime.Model;
using Xunit;

namespace Agile.Now.Runtime.Test.Data;

public class Department_TestData : TestData<Department, DepartmentData> {
    public override void AssertEqualToRequest(DepartmentData expected, Department actual) {
        Assert.Equal(expected.DepartmentId.Value, actual.Id);
    }

    public override void AssertEqualToResponse(Department expected, Department actual) {
        Assert.Equal(expected.Id, actual.Id);
        Assert.Equal(expected.ExternalId, actual.ExternalId);
        Assert.Equal(expected.Name, actual.Name);
        Assert.Equal(expected.DepartmentTypeId.Id, actual.DepartmentTypeId.Id);
        Assert.Equal(expected.ParentDepartmentId.Id ?? "", actual.ParentDepartmentId.Id ?? "");
        Assert.Equal(expected.ContactName, actual.ContactName);
        Assert.Equal(expected.ContactEmail, actual.ContactEmail);
        Assert.Equal(expected.CountryId.Id, actual.CountryId.Id);
    }

    public static readonly string[] Departments = new[] {
        "E074CD22-69BD-4935-84CA-773FA62CE399",
        "2E97527D-5BD7-4CC0-81B8-14B6C2CA325F",
        "106BA31C-3924-456E-879F-1EDCE47A86BA"
    };

    public override IEnumerable<DepartmentData> GenerateRequestData() =>
        Departments.Select(i => new DepartmentData(departmentId: new("Id", i)));
}

public static class TestData_Extension {
    public static DepartmentText ToDepartmentPatchData(this DepartmentData departmentData) =>
        new DepartmentText(departmentId: departmentData.DepartmentId.Value);
}
