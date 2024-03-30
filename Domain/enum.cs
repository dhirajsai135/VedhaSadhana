using System.ComponentModel;

public enum MaterialType
{
    Video,
    Document,
    Presentation
}

public enum Subject
{
    Vedam,
    Smartham
}

public enum SubjectType
{
    [Description("Rug Vedham")]
    RigVedham = 1,

    [Description("Yajur Vedham")]
    YajurVedham = 2,

    [Description("Sama Vedham")]
    SamaVedham = 3,

    [Description("Atharvana Vedham")]
    AtharvanaVedham = 4,

    [Description("Japalu")]
    Japalu = 5,

    [Description("Vrathalu")]
    Vrathalu = 6,

    [Description("Homalu")]
    Homalu = 7,

    [Description("Vedha Parayana")]
    VedhaParayanam = 8
}