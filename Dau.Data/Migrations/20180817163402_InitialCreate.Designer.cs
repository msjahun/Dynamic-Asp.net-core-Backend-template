﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;


namespace Dau.Data.Migrations
{
    [DbContext(typeof(fees_and_facilitiesContext))]
    [Migration("20180817163402_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dau.Core.Domain.BankAccount.AccountInformationParameter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("account_information_parameter");
                });

            modelBuilder.Entity("Dau.Core.Domain.BankAccount.AccountInformationParameterTranslation", b =>
                {
                    b.Property<int>("AccountInfoNonTransId")
                        .HasColumnName("account_info_non_trans_id");

                    b.Property<int>("LanguageId")
                        .HasColumnName("language_id");

                    b.Property<string>("Parameter")
                        .IsRequired()
                        .HasColumnName("parameter")
                        .HasMaxLength(400)
                        .IsUnicode(false);

                    b.HasKey("AccountInfoNonTransId", "LanguageId");

                    b.HasIndex("AccountInfoNonTransId")
                        .HasName("IX_account_info_non_trans_id");

                    b.HasIndex("LanguageId")
                        .HasName("IX_language_id");

                    b.ToTable("account_information_parameter_translation");
                });

            modelBuilder.Entity("Dau.Core.Domain.BankAccount.AccountParameterValues", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CurrencyId")
                        .HasColumnName("currency_id");

                    b.Property<int>("ParameterId")
                        .HasColumnName("parameter_id");

                    b.HasKey("Id");

                    b.HasIndex("CurrencyId")
                        .HasName("IX_currency_id");

                    b.HasIndex("ParameterId")
                        .HasName("IX_parameter_id");

                    b.ToTable("account_parameter_values");
                });

            modelBuilder.Entity("Dau.Core.Domain.BankAccount.AccountParameterValuesTranslation", b =>
                {
                    b.Property<int>("LanguageId")
                        .HasColumnName("language_id");

                    b.Property<int>("AccountParamsValuesNonTransId")
                        .HasColumnName("account_params_values_non_trans_id");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnName("value")
                        .HasMaxLength(300)
                        .IsUnicode(false);

                    b.HasKey("LanguageId", "AccountParamsValuesNonTransId");

                    b.HasIndex("AccountParamsValuesNonTransId")
                        .HasName("IX_account_params_values_non_trans_id");

                    b.HasIndex("LanguageId")
                        .HasName("IX_language_id");

                    b.ToTable("account_parameter_values_translation");
                });

            modelBuilder.Entity("Dau.Core.Domain.BankAccount.BankCurrencyTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BankAddress")
                        .HasColumnName("bank_address");

                    b.Property<int>("BankId")
                        .HasColumnName("bank_id");

                    b.Property<string>("BankRegistrationNo")
                        .HasColumnName("bank_registration_no");

                    b.Property<string>("CurrencyName")
                        .IsRequired()
                        .HasColumnName("currency_name")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("BankId")
                        .HasName("IX_bank_id");

                    b.ToTable("bank_currency_table");
                });

            modelBuilder.Entity("Dau.Core.Domain.Dormitory.DormitoriesTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DormitoryTypeId")
                        .HasColumnName("dormitory_type_id");

                    b.Property<string>("MapLatitude")
                        .IsRequired()
                        .HasColumnName("map_latitude")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("MapLongitude")
                        .IsRequired()
                        .HasColumnName("map_longitude")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("RoomPriceCurrency")
                        .IsRequired()
                        .HasColumnName("room_price_currency")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("RoomPriceCurrencySymbol")
                        .IsRequired()
                        .HasColumnName("room_price_currency_symbol")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("DormitoryTypeId")
                        .HasName("IX_dormitory_type_id");

                    b.ToTable("dormitories_table");
                });

            modelBuilder.Entity("Dau.Core.Domain.Dormitory.DormitoriesTableTranslation", b =>
                {
                    b.Property<int>("LanguageId")
                        .HasColumnName("language_id");

                    b.Property<int>("DormitoriesTableNonTransId")
                        .HasColumnName("dormitories_table_non_trans_id");

                    b.Property<string>("DormitoryAddress")
                        .IsRequired()
                        .HasColumnName("dormitory_address")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("DormitoryName")
                        .IsRequired()
                        .HasColumnName("dormitory_name")
                        .HasMaxLength(300)
                        .IsUnicode(false);

                    b.Property<string>("GenderAllocation")
                        .IsRequired()
                        .HasColumnName("gender_allocation")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<string>("RoomsPaymentPeriod")
                        .IsRequired()
                        .HasColumnName("rooms_payment_period")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.HasKey("LanguageId", "DormitoriesTableNonTransId");

                    b.HasIndex("DormitoriesTableNonTransId")
                        .HasName("IX_dormitories_table_non_trans_id");

                    b.HasIndex("LanguageId")
                        .HasName("IX_language_id");

                    b.ToTable("dormitories_table_translation");
                });

            modelBuilder.Entity("Dau.Core.Domain.Dormitory.DormitoryBankAccountTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasColumnName("bank_name")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int>("DormitoryId")
                        .HasColumnName("dormitory_id");

                    b.HasKey("Id");

                    b.HasIndex("DormitoryId")
                        .HasName("IX_dormitory_id");

                    b.ToTable("dormitory_bank_account_table");
                });

            modelBuilder.Entity("Dau.Core.Domain.Dormitory.DormitoryInformationTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DormitoryTypeId")
                        .HasColumnName("dormitory_type_id");

                    b.HasKey("Id");

                    b.HasIndex("DormitoryTypeId")
                        .HasName("IX_dormitory_type_id");

                    b.ToTable("dormitory_information_table");
                });

            modelBuilder.Entity("Dau.Core.Domain.Dormitory.DormitoryInformationTableTranslation", b =>
                {
                    b.Property<int>("LanguageId")
                        .HasColumnName("language_id");

                    b.Property<int>("DormitoryInfoNonTransId")
                        .HasColumnName("dormitory_info_non_trans_id");

                    b.Property<string>("Information")
                        .IsRequired()
                        .HasColumnName("information")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.HasKey("LanguageId", "DormitoryInfoNonTransId");

                    b.HasIndex("DormitoryInfoNonTransId")
                        .HasName("IX_dormitory_info_non_trans_id");

                    b.HasIndex("LanguageId")
                        .HasName("IX_language_id");

                    b.ToTable("dormitory_information_table_translation");
                });

            modelBuilder.Entity("Dau.Core.Domain.Dormitory.DormitoryType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("dormitory_type");
                });

            modelBuilder.Entity("Dau.Core.Domain.Dormitory.DormitoryTypeTranslation", b =>
                {
                    b.Property<int>("LanguageId")
                        .HasColumnName("language_id");

                    b.Property<int>("DormitoryTypeNonTransId")
                        .HasColumnName("dormitory_type_non_trans_id");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnName("type_name")
                        .HasMaxLength(300)
                        .IsUnicode(false);

                    b.HasKey("LanguageId", "DormitoryTypeNonTransId");

                    b.HasIndex("DormitoryTypeNonTransId")
                        .HasName("IX_dormitory_type_non_trans_id");

                    b.HasIndex("LanguageId")
                        .HasName("IX_language_id");

                    b.ToTable("dormitory_type_translation");
                });

            modelBuilder.Entity("Dau.Core.Domain.Facility.FacilityOption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FacilityId")
                        .HasColumnName("facility_id");

                    b.HasKey("Id");

                    b.HasIndex("FacilityId")
                        .HasName("IX_facility_id");

                    b.ToTable("facility_option");
                });

            modelBuilder.Entity("Dau.Core.Domain.Facility.FacilityOptionTranslation", b =>
                {
                    b.Property<int>("FacilityOptionNonTransId")
                        .HasColumnName("facility_option_non_trans_id");

                    b.Property<int>("LanguageId")
                        .HasColumnName("language_id");

                    b.Property<string>("FacilityOption")
                        .IsRequired()
                        .HasColumnName("facility_option")
                        .HasMaxLength(300)
                        .IsUnicode(false);

                    b.Property<string>("FacilityOptionDescription")
                        .IsRequired()
                        .HasColumnName("facility_option_description")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.HasKey("FacilityOptionNonTransId", "LanguageId");

                    b.HasIndex("FacilityOptionNonTransId")
                        .HasName("IX_facility_option_non_trans_id");

                    b.HasIndex("LanguageId")
                        .HasName("IX_language_id");

                    b.ToTable("facility_option_translation");
                });

            modelBuilder.Entity("Dau.Core.Domain.Facility.FacilityTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FacilityIconUrl")
                        .IsRequired()
                        .HasColumnName("facility_icon_url")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("facility_table");
                });

            modelBuilder.Entity("Dau.Core.Domain.Facility.FacilityTableTranslation", b =>
                {
                    b.Property<int>("LanguageId")
                        .HasColumnName("language_id");

                    b.Property<int>("FacilityTableNonTransId")
                        .HasColumnName("facility_table_non_trans_id");

                    b.Property<string>("FacilityDescription")
                        .IsRequired()
                        .HasColumnName("facility_description")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("FacilityTitle")
                        .IsRequired()
                        .HasColumnName("facility_title")
                        .HasMaxLength(300)
                        .IsUnicode(false);

                    b.HasKey("LanguageId", "FacilityTableNonTransId");

                    b.HasIndex("FacilityTableNonTransId")
                        .HasName("IX_facility_table_non_trans_id");

                    b.HasIndex("LanguageId")
                        .HasName("IX_language_id");

                    b.ToTable("facility_table_translation");
                });

            modelBuilder.Entity("Dau.Core.Domain.Language.LanguageTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LanguageCode")
                        .IsRequired()
                        .HasColumnName("language_code")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(300)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("language_table");
                });

            modelBuilder.Entity("Dau.Core.Domain.Room.RoomFacility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FacilityId")
                        .HasColumnName("facility_id");

                    b.Property<int?>("FacilityOptionId")
                        .HasColumnName("facility_option_id");

                    b.Property<int>("RoomId")
                        .HasColumnName("room_id");

                    b.HasKey("Id");

                    b.HasIndex("FacilityId")
                        .HasName("IX_facility_id");

                    b.HasIndex("RoomId")
                        .HasName("IX_room_id");

                    b.ToTable("room_facility");
                });

            modelBuilder.Entity("Dau.Core.Domain.Room.RoomTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DormitoryId")
                        .HasColumnName("dormitory_id");

                    b.Property<int>("NumRoomsLeft")
                        .HasColumnName("num_rooms_left");

                    b.Property<int>("RoomArea")
                        .HasColumnName("room_area");

                    b.Property<string>("RoomPictureUrl")
                        .IsRequired()
                        .HasColumnName("room_picture_url")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<double>("RoomPrice")
                        .HasColumnName("room_price");

                    b.Property<double>("RoomPriceInstallment")
                        .HasColumnName("room_price_installment");

                    b.HasKey("Id");

                    b.HasIndex("DormitoryId")
                        .HasName("IX_dormitory_id");

                    b.ToTable("room_table");
                });

            modelBuilder.Entity("Dau.Core.Domain.Room.RoomTableTranslation", b =>
                {
                    b.Property<int>("LanguageId")
                        .HasColumnName("language_id");

                    b.Property<int>("RoomTableNonTransId")
                        .HasColumnName("room_table_non_trans_id");

                    b.Property<string>("RoomTitle")
                        .IsRequired()
                        .HasColumnName("room_title")
                        .HasMaxLength(300)
                        .IsUnicode(false);

                    b.Property<string>("RoomType")
                        .IsRequired()
                        .HasColumnName("room_type")
                        .HasMaxLength(300)
                        .IsUnicode(false);

                    b.HasKey("LanguageId", "RoomTableNonTransId");

                    b.HasIndex("LanguageId")
                        .HasName("IX_language_id");

                    b.HasIndex("RoomTableNonTransId")
                        .HasName("IX_room_table_non_trans_id");

                    b.ToTable("room_table_translation");
                });

            modelBuilder.Entity("Dau.Core.Domain.BankAccount.AccountInformationParameterTranslation", b =>
                {
                    b.HasOne("Dau.Core.Domain.BankAccount.AccountInformationParameter", "AccountInfoNonTrans")
                        .WithMany("AccountInformationParameterTranslation")
                        .HasForeignKey("AccountInfoNonTransId")
                        .HasConstraintName("FK_dbo.account_information_parameter_translation_dbo.account_information_parameter_account_info_non_trans_id");

                    b.HasOne("Dau.Core.Domain.Language.LanguageTable", "Language")
                        .WithMany("AccountInformationParameterTranslation")
                        .HasForeignKey("LanguageId")
                        .HasConstraintName("FK_dbo.account_information_parameter_translation_dbo.language_table_language_id");
                });

            modelBuilder.Entity("Dau.Core.Domain.BankAccount.AccountParameterValues", b =>
                {
                    b.HasOne("Dau.Core.Domain.BankAccount.BankCurrencyTable", "Currency")
                        .WithMany("AccountParameterValues")
                        .HasForeignKey("CurrencyId")
                        .HasConstraintName("FK_dbo.account_parameter_values_dbo.bank_currency_table_currency_id");

                    b.HasOne("Dau.Core.Domain.BankAccount.AccountInformationParameter", "Parameter")
                        .WithMany("AccountParameterValues")
                        .HasForeignKey("ParameterId")
                        .HasConstraintName("FK_dbo.account_parameter_values_dbo.account_information_parameter_parameter_id");
                });

            modelBuilder.Entity("Dau.Core.Domain.BankAccount.AccountParameterValuesTranslation", b =>
                {
                    b.HasOne("Dau.Core.Domain.BankAccount.AccountParameterValues", "AccountParamsValuesNonTrans")
                        .WithMany("AccountParameterValuesTranslation")
                        .HasForeignKey("AccountParamsValuesNonTransId")
                        .HasConstraintName("FK_dbo.account_parameter_values_translation_dbo.account_parameter_values_account_params_values_non_trans_id");

                    b.HasOne("Dau.Core.Domain.Language.LanguageTable", "Language")
                        .WithMany("AccountParameterValuesTranslation")
                        .HasForeignKey("LanguageId")
                        .HasConstraintName("FK_dbo.account_parameter_values_translation_dbo.language_table_language_id");
                });

            modelBuilder.Entity("Dau.Core.Domain.BankAccount.BankCurrencyTable", b =>
                {
                    b.HasOne("Dau.Core.Domain.Dormitory.DormitoryBankAccountTable", "Bank")
                        .WithMany("BankCurrencyTable")
                        .HasForeignKey("BankId")
                        .HasConstraintName("FK_dbo.bank_currency_table_dbo.dormitory_bank_account_table_bank_id");
                });

            modelBuilder.Entity("Dau.Core.Domain.Dormitory.DormitoriesTable", b =>
                {
                    b.HasOne("Dau.Core.Domain.Dormitory.DormitoryType", "DormitoryType")
                        .WithMany("DormitoriesTable")
                        .HasForeignKey("DormitoryTypeId")
                        .HasConstraintName("FK_dbo.dormitories_table_dbo.dormitory_type_dormitory_type_id");
                });

            modelBuilder.Entity("Dau.Core.Domain.Dormitory.DormitoriesTableTranslation", b =>
                {
                    b.HasOne("Dau.Core.Domain.Dormitory.DormitoriesTable", "DormitoriesTableNonTrans")
                        .WithMany("DormitoriesTableTranslation")
                        .HasForeignKey("DormitoriesTableNonTransId")
                        .HasConstraintName("FK_dbo.dormitories_table_translation_dbo.dormitories_table_dormitories_table_non_trans_id");

                    b.HasOne("Dau.Core.Domain.Language.LanguageTable", "Language")
                        .WithMany("DormitoriesTableTranslation")
                        .HasForeignKey("LanguageId")
                        .HasConstraintName("FK_dbo.dormitories_table_translation_dbo.language_table_language_id");
                });

            modelBuilder.Entity("Dau.Core.Domain.Dormitory.DormitoryBankAccountTable", b =>
                {
                    b.HasOne("Dau.Core.Domain.Dormitory.DormitoriesTable", "Dormitory")
                        .WithMany("DormitoryBankAccountTable")
                        .HasForeignKey("DormitoryId")
                        .HasConstraintName("FK_dbo.dormitory_bank_account_table_dbo.dormitories_table_dormitory_id");
                });

            modelBuilder.Entity("Dau.Core.Domain.Dormitory.DormitoryInformationTable", b =>
                {
                    b.HasOne("Dau.Core.Domain.Dormitory.DormitoryType", "DormitoryType")
                        .WithMany("DormitoryInformationTable")
                        .HasForeignKey("DormitoryTypeId")
                        .HasConstraintName("FK_dbo.dormitory_information_table_dbo.dormitory_type_dormitory_type_id");
                });

            modelBuilder.Entity("Dau.Core.Domain.Dormitory.DormitoryInformationTableTranslation", b =>
                {
                    b.HasOne("Dau.Core.Domain.Dormitory.DormitoryInformationTable", "DormitoryInfoNonTrans")
                        .WithMany("DormitoryInformationTableTranslation")
                        .HasForeignKey("DormitoryInfoNonTransId")
                        .HasConstraintName("FK_dbo.dormitory_information_table_translation_dbo.dormitory_information_table_dormitory_info_non_trans_id");

                    b.HasOne("Dau.Core.Domain.Language.LanguageTable", "Language")
                        .WithMany("DormitoryInformationTableTranslation")
                        .HasForeignKey("LanguageId")
                        .HasConstraintName("FK_dbo.dormitory_information_table_translation_dbo.language_table_language_id");
                });

            modelBuilder.Entity("Dau.Core.Domain.Dormitory.DormitoryTypeTranslation", b =>
                {
                    b.HasOne("Dau.Core.Domain.Dormitory.DormitoryType", "DormitoryTypeNonTrans")
                        .WithMany("DormitoryTypeTranslation")
                        .HasForeignKey("DormitoryTypeNonTransId")
                        .HasConstraintName("FK_dbo.dormitory_type_translation_dbo.dormitory_type_dormitory_type_non_trans_id");

                    b.HasOne("Dau.Core.Domain.Language.LanguageTable", "Language")
                        .WithMany("DormitoryTypeTranslation")
                        .HasForeignKey("LanguageId")
                        .HasConstraintName("FK_dbo.dormitory_type_translation_dbo.language_table_language_id");
                });

            modelBuilder.Entity("Dau.Core.Domain.Facility.FacilityOption", b =>
                {
                    b.HasOne("Dau.Core.Domain.Facility.FacilityTable", "Facility")
                        .WithMany("FacilityOption")
                        .HasForeignKey("FacilityId")
                        .HasConstraintName("FK_dbo.facility_option_dbo.facility_table_facility_id");
                });

            modelBuilder.Entity("Dau.Core.Domain.Facility.FacilityOptionTranslation", b =>
                {
                    b.HasOne("Dau.Core.Domain.Facility.FacilityOption", "FacilityOptionNonTrans")
                        .WithMany("FacilityOptionTranslation")
                        .HasForeignKey("FacilityOptionNonTransId")
                        .HasConstraintName("FK_dbo.facility_option_translation_dbo.facility_option_facility_option_non_trans_id");

                    b.HasOne("Dau.Core.Domain.Language.LanguageTable", "Language")
                        .WithMany("FacilityOptionTranslation")
                        .HasForeignKey("LanguageId")
                        .HasConstraintName("FK_dbo.facility_option_translation_dbo.language_table_language_id");
                });

            modelBuilder.Entity("Dau.Core.Domain.Facility.FacilityTableTranslation", b =>
                {
                    b.HasOne("Dau.Core.Domain.Facility.FacilityTable", "FacilityTableNonTrans")
                        .WithMany("FacilityTableTranslation")
                        .HasForeignKey("FacilityTableNonTransId")
                        .HasConstraintName("FK_dbo.facility_table_translation_dbo.facility_table_facility_table_non_trans_id");

                    b.HasOne("Dau.Core.Domain.Language.LanguageTable", "Language")
                        .WithMany("FacilityTableTranslation")
                        .HasForeignKey("LanguageId")
                        .HasConstraintName("FK_dbo.facility_table_translation_dbo.language_table_language_id");
                });

            modelBuilder.Entity("Dau.Core.Domain.Room.RoomFacility", b =>
                {
                    b.HasOne("Dau.Core.Domain.Facility.FacilityTable", "Facility")
                        .WithMany("RoomFacility")
                        .HasForeignKey("FacilityId")
                        .HasConstraintName("FK_dbo.room_facility_dbo.facility_table_facility_id");

                    b.HasOne("Dau.Core.Domain.Room.RoomTable", "Room")
                        .WithMany("RoomFacility")
                        .HasForeignKey("RoomId")
                        .HasConstraintName("FK_dbo.room_facility_dbo.room_table_room_id");
                });

            modelBuilder.Entity("Dau.Core.Domain.Room.RoomTable", b =>
                {
                    b.HasOne("Dau.Core.Domain.Dormitory.DormitoriesTable", "Dormitory")
                        .WithMany("RoomTable")
                        .HasForeignKey("DormitoryId")
                        .HasConstraintName("FK_dbo.room_table_dbo.dormitories_table_dormitory_id");
                });

            modelBuilder.Entity("Dau.Core.Domain.Room.RoomTableTranslation", b =>
                {
                    b.HasOne("Dau.Core.Domain.Language.LanguageTable", "Language")
                        .WithMany("RoomTableTranslation")
                        .HasForeignKey("LanguageId")
                        .HasConstraintName("FK_dbo.room_table_translation_dbo.language_table_language_id");

                    b.HasOne("Dau.Core.Domain.Room.RoomTable", "RoomTableNonTrans")
                        .WithMany("RoomTableTranslation")
                        .HasForeignKey("RoomTableNonTransId")
                        .HasConstraintName("FK_dbo.room_table_translation_dbo.room_table_room_table_non_trans_id");
                });
#pragma warning restore 612, 618
        }
    }
}
