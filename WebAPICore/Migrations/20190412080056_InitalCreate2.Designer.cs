﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPICore.DataAccess;

namespace WebAPICore.Migrations
{
    [DbContext(typeof(MainContext))]
    [Migration("20190412080056_InitalCreate2")]
    partial class InitalCreate2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAPICore.DataModel.Models.Album", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<string>("Description")
                        .HasMaxLength(2000);

                    b.Property<Guid>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Name")
                        .HasMaxLength(500);

                    b.Property<DateTime?>("PublishDate");

                    b.Property<bool>("StatusId");

                    b.HasKey("Id");

                    b.ToTable("Album");
                });

            modelBuilder.Entity("WebAPICore.DataModel.Models.AttachmentFile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<byte[]>("FileData");

                    b.Property<string>("FileExtension");

                    b.Property<string>("FileName");

                    b.Property<int>("FileSize");

                    b.Property<string>("FileType");

                    b.Property<Guid>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<Guid?>("MovieId");

                    b.Property<Guid>("ParentId");

                    b.Property<string>("Remarks");

                    b.Property<bool>("StatusId");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("AttachmentFile");
                });

            modelBuilder.Entity("WebAPICore.DataModel.Models.AuditTrail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<Guid>("ItemId");

                    b.Property<Guid>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<bool>("StatusId");

                    b.Property<string>("TableName");

                    b.Property<string>("TrackChange");

                    b.Property<string>("TransactionId");

                    b.HasKey("Id");

                    b.ToTable("AuditTrail");
                });

            modelBuilder.Entity("WebAPICore.DataModel.Models.Blood", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<Guid>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<bool>("StatusId");

                    b.HasKey("Id");

                    b.ToTable("Blood");
                });

            modelBuilder.Entity("WebAPICore.DataModel.Models.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<Guid>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Name");

                    b.Property<bool>("StatusId");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("WebAPICore.DataModel.Models.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<Guid>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<Guid>("ParentId");

                    b.Property<bool>("StatusId");

                    b.HasKey("Id");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("WebAPICore.DataModel.Models.Idol", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Age");

                    b.Property<Guid?>("AvatarImage");

                    b.Property<Guid?>("BloodId");

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<DateTime?>("DateOfBirth");

                    b.Property<string>("FirstName")
                        .HasMaxLength(200);

                    b.Property<string>("Habit");

                    b.Property<double>("Height");

                    b.Property<string>("LastName")
                        .HasMaxLength(200);

                    b.Property<string>("MiddleName")
                        .HasMaxLength(200);

                    b.Property<Guid>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("NickName")
                        .HasMaxLength(200);

                    b.Property<bool>("Sex")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("Star")
                        .HasMaxLength(200);

                    b.Property<bool>("StatusId");

                    b.Property<double>("Weight");

                    b.HasKey("Id");

                    b.HasIndex("BloodId");

                    b.ToTable("Idol");
                });

            modelBuilder.Entity("WebAPICore.DataModel.Models.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AltName")
                        .HasMaxLength(200);

                    b.Property<Guid?>("AttachmentFileId");

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<string>("Description")
                        .HasMaxLength(2000);

                    b.Property<string>("Extension")
                        .HasMaxLength(20);

                    b.Property<double>("Height");

                    b.Property<string>("Link")
                        .HasMaxLength(500);

                    b.Property<Guid>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<double>("Size");

                    b.Property<bool>("StatusId");

                    b.Property<double>("Width");

                    b.HasKey("Id");

                    b.HasIndex("AttachmentFileId");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("WebAPICore.DataModel.Models.MappingAlbumIdol", b =>
                {
                    b.Property<Guid>("AlbumId");

                    b.Property<Guid>("IdolId");

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<Guid>("Id");

                    b.Property<Guid>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<bool>("StatusId");

                    b.HasKey("AlbumId", "IdolId");

                    b.HasAlternateKey("Id");

                    b.HasIndex("IdolId");

                    b.ToTable("MappingAlbumIdol");
                });

            modelBuilder.Entity("WebAPICore.DataModel.Models.MappingAlbumImage", b =>
                {
                    b.Property<Guid>("AlbumId");

                    b.Property<Guid>("ImageId");

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<Guid>("Id");

                    b.Property<Guid>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<bool>("StatusId");

                    b.HasKey("AlbumId", "ImageId");

                    b.HasAlternateKey("Id");

                    b.HasIndex("ImageId");

                    b.ToTable("MappingAlbumImage");
                });

            modelBuilder.Entity("WebAPICore.DataModel.Models.MappingMovieCategory", b =>
                {
                    b.Property<Guid>("MovieId");

                    b.Property<Guid>("CategoryId");

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<Guid>("Id");

                    b.Property<Guid>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<bool>("StatusId");

                    b.HasKey("MovieId", "CategoryId");

                    b.HasAlternateKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("MappingMovieCategory");
                });

            modelBuilder.Entity("WebAPICore.DataModel.Models.MappingMovieIdol", b =>
                {
                    b.Property<Guid>("MovieId");

                    b.Property<Guid>("IdolId");

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<Guid>("Id");

                    b.Property<Guid>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<bool>("StatusId");

                    b.HasKey("MovieId", "IdolId");

                    b.HasAlternateKey("Id");

                    b.HasIndex("IdolId");

                    b.ToTable("MappingMovieIdol");
                });

            modelBuilder.Entity("WebAPICore.DataModel.Models.MappingMovieImage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<Guid>("ImageId");

                    b.Property<Guid>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<Guid>("MovieId");

                    b.Property<bool>("StatusId");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.HasIndex("MovieId");

                    b.ToTable("MappingMovieImage");
                });

            modelBuilder.Entity("WebAPICore.DataModel.Models.MappingUserComment", b =>
                {
                    b.Property<Guid>("UserProfileId");

                    b.Property<Guid>("CommentId");

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<Guid>("Id");

                    b.Property<Guid>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<bool>("StatusId");

                    b.HasKey("UserProfileId", "CommentId");

                    b.HasAlternateKey("Id");

                    b.HasIndex("CommentId");

                    b.ToTable("MappingUserComment");
                });

            modelBuilder.Entity("WebAPICore.DataModel.Models.Movie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .HasMaxLength(50);

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<string>("Description")
                        .HasMaxLength(2000);

                    b.Property<double>("Duration");

                    b.Property<Guid?>("LabelImageId");

                    b.Property<Guid>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<DateTime?>("PublishDate");

                    b.Property<double>("Rate");

                    b.Property<bool>("StatusId");

                    b.Property<string>("Title")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("WebAPICore.DataModel.Models.SourceLink", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<string>("DownloadLink")
                        .HasMaxLength(700);

                    b.Property<string>("Link")
                        .HasMaxLength(700);

                    b.Property<Guid>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<Guid>("MovieId");

                    b.Property<string>("Name")
                        .HasMaxLength(200);

                    b.Property<string>("Resolution")
                        .HasMaxLength(50);

                    b.Property<string>("Server")
                        .HasMaxLength(200);

                    b.Property<bool>("StatusId");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("SourceLink");
                });

            modelBuilder.Entity("WebAPICore.DataModel.Models.Studio", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<Guid>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Name");

                    b.Property<bool>("StatusId");

                    b.HasKey("Id");

                    b.ToTable("Studio");
                });

            modelBuilder.Entity("WebAPICore.DataModel.Models.UserProfile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Age");

                    b.Property<Guid?>("AttachmentFileId");

                    b.Property<Guid?>("AvatarImage");

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<DateTime?>("DateOfBirth");

                    b.Property<string>("Email")
                        .HasMaxLength(200);

                    b.Property<string>("FirstName")
                        .HasMaxLength(200);

                    b.Property<string>("LastName")
                        .HasMaxLength(200);

                    b.Property<string>("MiddleName")
                        .HasMaxLength(200);

                    b.Property<Guid>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<bool?>("Sex");

                    b.Property<bool>("StatusId");

                    b.HasKey("Id");

                    b.HasIndex("AttachmentFileId");

                    b.ToTable("UserProfile");
                });

            modelBuilder.Entity("WebAPICore.DataModel.Models.AttachmentFile", b =>
                {
                    b.HasOne("WebAPICore.DataModel.Models.Movie")
                        .WithMany("AttachmentFiles")
                        .HasForeignKey("MovieId");
                });

            modelBuilder.Entity("WebAPICore.DataModel.Models.Idol", b =>
                {
                    b.HasOne("WebAPICore.DataModel.Models.Blood", "Blood")
                        .WithMany("Idols")
                        .HasForeignKey("BloodId");
                });

            modelBuilder.Entity("WebAPICore.DataModel.Models.Image", b =>
                {
                    b.HasOne("WebAPICore.DataModel.Models.AttachmentFile", "AttachmentFile")
                        .WithMany()
                        .HasForeignKey("AttachmentFileId");
                });

            modelBuilder.Entity("WebAPICore.DataModel.Models.MappingAlbumIdol", b =>
                {
                    b.HasOne("WebAPICore.DataModel.Models.Album", "Album")
                        .WithMany("AlbumIdols")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebAPICore.DataModel.Models.Idol", "Idol")
                        .WithMany("AlbumIdols")
                        .HasForeignKey("IdolId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebAPICore.DataModel.Models.MappingAlbumImage", b =>
                {
                    b.HasOne("WebAPICore.DataModel.Models.Album", "Album")
                        .WithMany("AlbumImages")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebAPICore.DataModel.Models.Image", "Image")
                        .WithMany("AlbumImages")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebAPICore.DataModel.Models.MappingMovieCategory", b =>
                {
                    b.HasOne("WebAPICore.DataModel.Models.Category", "Category")
                        .WithMany("MovieCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebAPICore.DataModel.Models.Movie", "Movie")
                        .WithMany("MovieCategories")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebAPICore.DataModel.Models.MappingMovieIdol", b =>
                {
                    b.HasOne("WebAPICore.DataModel.Models.Idol", "Idol")
                        .WithMany("MovieIdols")
                        .HasForeignKey("IdolId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebAPICore.DataModel.Models.Movie", "Movie")
                        .WithMany("MovieIdols")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebAPICore.DataModel.Models.MappingMovieImage", b =>
                {
                    b.HasOne("WebAPICore.DataModel.Models.Image", "Image")
                        .WithMany("MovieImages")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebAPICore.DataModel.Models.Movie", "Movie")
                        .WithMany("MovieImages")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebAPICore.DataModel.Models.MappingUserComment", b =>
                {
                    b.HasOne("WebAPICore.DataModel.Models.Comment", "Comment")
                        .WithMany("UserComments")
                        .HasForeignKey("CommentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebAPICore.DataModel.Models.UserProfile", "UserProfile")
                        .WithMany("UserComments")
                        .HasForeignKey("UserProfileId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebAPICore.DataModel.Models.SourceLink", b =>
                {
                    b.HasOne("WebAPICore.DataModel.Models.Movie", "Movie")
                        .WithMany("SourceLinks")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebAPICore.DataModel.Models.UserProfile", b =>
                {
                    b.HasOne("WebAPICore.DataModel.Models.AttachmentFile", "AttachmentFile")
                        .WithMany()
                        .HasForeignKey("AttachmentFileId");
                });
#pragma warning restore 612, 618
        }
    }
}