# Reading XML data with XSD definitions into DotNetCore Objects

This is a short article about how to import complex XML files into C# classes in DotNetCore.

I've written this article because there's so much junk out there about how to do it.

This article describes specifically setting up an reader for GPX formatted files.

1. Set up a Console DotNetCore project with Visual Studio.
2. Get the XSD file for the format and add it to a subfolder, in this case *Gpx*.
3. Find XSD.exe.  It's in the Windows SDK - in my case *C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8 Tools*
4. Run it against the xsd file:

```ps
PS C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8 Tools> .\xsd.exe "D:\Documents\GitHub\GPXReader\Gpx\gpx.xsd" /c /outputdir:"D:\Documents\GitHub\CEC.OSM\CEC.OSM\Data\Gpx"
Microsoft (R) Xml Schemas/DataTypes support utility
[Microsoft (R) .NET Framework, Version 4.8.3928.0]
Copyright (C) Microsoft Corporation. All rights reserved.
Writing file 'D:\Documents\GitHub\GPXReader\Gpx\gpx.cs'.
PS C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8 Tools>
```

