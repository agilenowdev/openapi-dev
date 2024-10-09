using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Agile.Now.AccessHub.Model;
using Agile.Now.Api.Test;

namespace Agile.Now.ApiAccounts.Test.Api;

public class Picture_TestData : TestData<Picture, PictureData> {
    public const string PictureData = "0123456789";

    public override void AssertEqualToRequest(PictureData data0, Picture data1) { }
    public override void AssertEqualToResponse(Picture data0, Picture data1) { }

    public override IEnumerable<PictureData> GenerateRequestData() {
        yield return new PictureData(PictureData.ToStream());
    }
}

public static class AccountPictureTestData_Extension {
    public static Stream ToStream(this string s) =>
        new TestStream(Encoding.UTF8.GetBytes(Convert.ToBase64String(Encoding.UTF8.GetBytes(s ?? ""))));
}
public class TestStream : MemoryStream {
    public TestStream(byte[] buffer) : base(buffer) { }
    public override int ReadTimeout { get => 10000; set => base.ReadTimeout = value; }
    public override int WriteTimeout { get => 10000; set => base.WriteTimeout = value; }
    public override bool CanTimeout => true;
}
