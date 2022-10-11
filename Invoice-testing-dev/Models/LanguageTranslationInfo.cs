namespace Invoice_testing_dev.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("CultureDetail")]
    public partial class CultureDetail
    {
        public Guid id { get; set; }
        [Required]
        [StringLength(50)]
        public string? Name { get; set; }
        [Required]
        [StringLength(50)]
        public string? specName { get; set; }
        [Required]
        [StringLength(50)]
        public string? EnglishName { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsCurrentCulture { get; set; }
    }

    [Table("Client_Language")]
    public partial class Client_Language
    {
        public Guid id { get; set; }
        public Guid ClientId { get; set; }
        public Guid LanguageGuid { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModificationHistory { get; set; }
    }
    [Table("ClientKeywordsInfo")]
    public partial class ClientKeywordsInfo
    {
        public Guid id { get; set; }
        public Guid ClientId { get; set; }
        public string? Keywordtext { get; set; }
        public string? KeywordValue { get; set; }
        public Guid RootId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModificationHistory { get; set; }
    }

    [Table("ClientLanguageRootInfo")]
    public partial class ClientLanguageRootInfo
    {
        public Guid id { get; set; }
        public Guid ClientId { get; set; }
        public string? RootName { get; set; }
        public string? DisplayName { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModificationHistory { get; set; }
    }

    [Table("ClientLanguageTranslatedInfo")]
    public partial class ClientLanguageTranslatedInfo
    {
        public Guid id { get; set; }
        public Guid ClientId { get; set; }
        public Guid LanguageId { get; set; }
        public Guid KeywordId { get; set; }
        public string? Value { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? ModificationHistory { get; set; }
        public bool VisibleStatus { get; set; }
    }



    public class CustomKeywordInfo
    {
        public string? KeywordName { get; set; }
        public string? DefaultValue { get; set; }
        public Guid RootId { get; set; }
    }

    public class RootInfo
    {
        public string? RootName { get; set; }
        public string? DefaultValue { get; set; }
    }
    public class RootInfoForGrid
    {
        public Guid id { get; set; }
        public string? RootName { get; set; }
        public string? DisplayName { get; set; }
    }

    public class KeywordInfoForRootId
    {
        public Guid ClientKeywordsInfoId { get; set; }
        public Guid ClientLanguageTranslatedInfoId { get; set; }
        public Guid ClientId { get; set; }
        public string? KeywordText { get; set; }
        public string? KeywordValue { get; set; }
        public string? CustomValue { get; set; }
    }

    public class LanguageCustomization
    {
        public string? KeywordName { get; set; }
        public string? CustomValue { get; set; }

        public bool VisibleStatus { get; set; }
    }
}
