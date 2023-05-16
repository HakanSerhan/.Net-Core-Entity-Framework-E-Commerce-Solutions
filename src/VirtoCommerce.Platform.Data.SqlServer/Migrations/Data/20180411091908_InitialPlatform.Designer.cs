// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using VirtoCommerce.Platform.Data.Repositories;

namespace VirtoCommerce.Platform.Data.SqlServer.Migrations.Data
{
    [DbContext(typeof(PlatformDbContext))]
    [Migration("20180411091908_InitialPlatform")]
    partial class InitialPlatform
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VirtoCommerce.Platform.Data.Model.AssetEntryEntity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(128);

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(64);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Group")
                        .HasMaxLength(64);

                    b.Property<string>("LanguageCode")
                        .HasMaxLength(10);

                    b.Property<string>("MimeType")
                        .HasMaxLength(128);

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(64);

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(1024);

                    b.Property<string>("RelativeUrl")
                        .IsRequired()
                        .HasMaxLength(2083);

                    b.Property<long>("Size");

                    b.Property<string>("TenantId")
                        .HasMaxLength(128);

                    b.Property<string>("TenantType")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("RelativeUrl", "Name")
                        .HasName("IX_AssetEntry_RelativeUrl_Name");

                    b.ToTable("AssetEntry");
                });

            modelBuilder.Entity("VirtoCommerce.Platform.Data.Model.DynamicPropertyDictionaryItemEntity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(128);

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(64);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(64);

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Name")
                        .HasMaxLength(512);

                    b.Property<string>("PropertyId");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId", "Name")
                        .IsUnique()
                        .HasName("IX_PlatformDynamicPropertyDictionaryItem_PropertyId_Name")
                        .HasFilter("[PropertyId] IS NOT NULL AND [Name] IS NOT NULL");

                    b.ToTable("PlatformDynamicPropertyDictionaryItem");
                });

            modelBuilder.Entity("VirtoCommerce.Platform.Data.Model.DynamicPropertyDictionaryItemNameEntity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(128);

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(64);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("DictionaryItemId");

                    b.Property<string>("Locale")
                        .HasMaxLength(64);

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(64);

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Name")
                        .HasMaxLength(512);

                    b.HasKey("Id");

                    b.HasIndex("DictionaryItemId", "Locale", "Name")
                        .IsUnique()
                        .HasName("IX_PlatformDynamicPropertyDictionaryItemName_DictionaryItemId_Locale_Name")
                        .HasFilter("[DictionaryItemId] IS NOT NULL AND [Locale] IS NOT NULL AND [Name] IS NOT NULL");

                    b.ToTable("PlatformDynamicPropertyDictionaryItemName");
                });

            modelBuilder.Entity("VirtoCommerce.Platform.Data.Model.DynamicPropertyEntity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(128);

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(64);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description")
                        .HasMaxLength(256);

                    b.Property<int?>("DisplayOrder");

                    b.Property<bool>("IsArray");

                    b.Property<bool>("IsDictionary");

                    b.Property<bool>("IsMultilingual");

                    b.Property<bool>("IsRequired");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(64);

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("ObjectType")
                        .HasMaxLength(256);

                    b.Property<string>("ValueType")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("ObjectType", "Name")
                        .IsUnique()
                        .HasName("IX_PlatformDynamicProperty_ObjectType_Name")
                        .HasFilter("[ObjectType] IS NOT NULL AND [Name] IS NOT NULL");

                    b.ToTable("PlatformDynamicProperty");
                });

            modelBuilder.Entity("VirtoCommerce.Platform.Data.Model.DynamicPropertyNameEntity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(128);

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(64);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Locale")
                        .HasMaxLength(64);

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(64);

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("PropertyId");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId", "Locale", "Name")
                        .IsUnique()
                        .HasName("IX_PlatformDynamicPropertyName_PropertyId_Locale_Name")
                        .HasFilter("[PropertyId] IS NOT NULL AND [Locale] IS NOT NULL AND [Name] IS NOT NULL");

                    b.ToTable("PlatformDynamicPropertyName");
                });

            modelBuilder.Entity("VirtoCommerce.Platform.Data.Model.DynamicPropertyObjectValueEntity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(128);

                    b.Property<bool?>("BooleanValue");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(64);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime?>("DateTimeValue");

                    b.Property<decimal?>("DecimalValue")
                        .HasColumnType("decimal(18,5)");

                    b.Property<string>("DictionaryItemId");

                    b.Property<int?>("IntegerValue");

                    b.Property<string>("Locale")
                        .HasMaxLength(64);

                    b.Property<string>("LongTextValue");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(64);

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("ObjectId")
                        .HasMaxLength(128);

                    b.Property<string>("ObjectType")
                        .HasMaxLength(256);

                    b.Property<string>("PropertyId");

                    b.Property<string>("ShortTextValue")
                        .HasMaxLength(512);

                    b.Property<string>("ValueType")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("DictionaryItemId");

                    b.HasIndex("PropertyId");

                    b.HasIndex("ObjectType", "ObjectId")
                        .HasName("IX_ObjectType_ObjectId");

                    b.ToTable("PlatformDynamicPropertyObjectValue");
                });

            modelBuilder.Entity("VirtoCommerce.Platform.Data.Model.OperationLogEntity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(128);

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(64);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Detail")
                        .HasMaxLength(2048);

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(64);

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("ObjectId")
                        .HasMaxLength(200);

                    b.Property<string>("ObjectType")
                        .HasMaxLength(50);

                    b.Property<string>("OperationType")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("ObjectType", "ObjectId")
                        .HasName("IX_ObjectType_ObjectId");

                    b.ToTable("PlatformOperationLog");
                });

            modelBuilder.Entity("VirtoCommerce.Platform.Data.Model.SettingEntity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(128);

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(64);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(64);

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("ObjectId")
                        .HasMaxLength(128);

                    b.Property<string>("ObjectType")
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("ObjectType", "ObjectId")
                        .HasName("IX_ObjectType_ObjectId");

                    b.ToTable("PlatformSetting");
                });

            modelBuilder.Entity("VirtoCommerce.Platform.Data.Model.SettingValueEntity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(128);

                    b.Property<bool>("BooleanValue");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(64);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime?>("DateTimeValue");

                    b.Property<decimal>("DecimalValue")
                        .HasColumnType("decimal(18,5)");

                    b.Property<int>("IntegerValue");

                    b.Property<string>("LongTextValue");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(64);

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("SettingId");

                    b.Property<string>("ShortTextValue")
                        .HasMaxLength(512);

                    b.Property<string>("ValueType")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("SettingId");

                    b.ToTable("PlatformSettingValue");
                });

            modelBuilder.Entity("VirtoCommerce.Platform.Data.Model.DynamicPropertyDictionaryItemEntity", b =>
                {
                    b.HasOne("VirtoCommerce.Platform.Data.Model.DynamicPropertyEntity", "Property")
                        .WithMany("DictionaryItems")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("VirtoCommerce.Platform.Data.Model.DynamicPropertyDictionaryItemNameEntity", b =>
                {
                    b.HasOne("VirtoCommerce.Platform.Data.Model.DynamicPropertyDictionaryItemEntity", "DictionaryItem")
                        .WithMany("DisplayNames")
                        .HasForeignKey("DictionaryItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("VirtoCommerce.Platform.Data.Model.DynamicPropertyNameEntity", b =>
                {
                    b.HasOne("VirtoCommerce.Platform.Data.Model.DynamicPropertyEntity", "Property")
                        .WithMany("DisplayNames")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("VirtoCommerce.Platform.Data.Model.DynamicPropertyObjectValueEntity", b =>
                {
                    b.HasOne("VirtoCommerce.Platform.Data.Model.DynamicPropertyDictionaryItemEntity", "DictionaryItem")
                        .WithMany("ObjectValues")
                        .HasForeignKey("DictionaryItemId");

                    b.HasOne("VirtoCommerce.Platform.Data.Model.DynamicPropertyEntity", "Property")
                        .WithMany("ObjectValues")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("VirtoCommerce.Platform.Data.Model.SettingValueEntity", b =>
                {
                    b.HasOne("VirtoCommerce.Platform.Data.Model.SettingEntity", "Setting")
                        .WithMany("SettingValues")
                        .HasForeignKey("SettingId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
