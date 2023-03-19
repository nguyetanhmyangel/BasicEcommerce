using System.ComponentModel;

namespace BasicEcommerce.Domain.Enums;

public enum UploadType: byte
{
    [Description(@"Images\Products")]
    Product,
    [Description(@"Images\ProfilePictures")]
    ProfilePicture,
    [Description(@"Documents")]
    Document
}