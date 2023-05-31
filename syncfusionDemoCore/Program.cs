var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Register Syncfusion License
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjE3NTMwNkAzMjMxMmUzMjJlMzNjL1NtRERxWmpTNmlVUkt0VlJNS3JoRng1ZTFTczZtWmN3c0FvV2IydzRZPQ==;Mgo+DSMBaFt+QHJqVk1lQ1JFaV1CX2BZfFlzR2lbd04QCV5EYF5SRHNdRlxnTHxRfkxiXHs=;Mgo+DSMBMAY9C3t2VFhiQlJPc0BBXHxLflF1VWFTelx6dl1WACFaRnZdQV1mS3pSckBhW3dXcn1R;Mgo+DSMBPh8sVXJ1S0R+X1pBaVxDQmFJfFBmR2lcfVRyfEUmHVdTRHRcQlhhTX9Xc0dhUXZac3A=;MjE3NTMxMEAzMjMxMmUzMjJlMzNUVzU1T1VoWEJNWmhMdzZwWTV3dzFCME5lSVNQMHN5NW1ib2xpOEsxYTdVPQ==;NRAiBiAaIQQuGjN/V0d+Xk9HfVpdXmJWfFN0RnNbdVtyfldOcDwsT3RfQF5jTHxXd0FmW31WeXxUQg==;ORg4AjUWIQA/Gnt2VFhiQlJPc0BBXHxLflF1VWFTelx6dl1WACFaRnZdQV1mS3pSckBhW3dXeXBQ;MjE3NTMxM0AzMjMxMmUzMjJlMzNpaEg4cGFETU1DaUJ2S0hHS3FkY3E5bEZkVFB0MEJERThldVhrUWJmWS80PQ==;MjE3NTMxNEAzMjMxMmUzMjJlMzNFSGU3S3IxOUVnSzFsVjI3Q1BDNDVlUFNHSHVkZFB5MVlDOVdRQTczMlRvPQ==;MjE3NTMxNUAzMjMxMmUzMjJlMzNtOWZ4ZEtIOXFZalNpUWR3cjdMeUtBS1ptVDZab0lURjlXT1JTOEpabU1ZPQ==;MjE3NTMxNkAzMjMxMmUzMjJlMzNvUU5VU09UMTY1OXl6V2k2K1kzM2kvTVIwZHdpdDJONDF1UTJLSXRpVjFnPQ==;MjE3NTMxN0AzMjMxMmUzMjJlMzNjL1NtRERxWmpTNmlVUkt0VlJNS3JoRng1ZTFTczZtWmN3c0FvV2IydzRZPQ==");

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
