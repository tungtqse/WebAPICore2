using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPICore.Migrations
{
    public partial class InitalCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Album",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    StatusId = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 500, nullable: true),
                    Description = table.Column<string>(maxLength: 2000, nullable: true),
                    PublishDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Album", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blood",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    StatusId = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blood", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    StatusId = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    StatusId = table.Column<bool>(nullable: false),
                    ParentId = table.Column<Guid>(nullable: false),
                    Content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    StatusId = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(maxLength: 200, nullable: true),
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    Duration = table.Column<double>(nullable: false),
                    Description = table.Column<string>(maxLength: 2000, nullable: true),
                    Rate = table.Column<double>(nullable: false),
                    PublishDate = table.Column<DateTime>(nullable: true),
                    LabelImageId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Studio",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    StatusId = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Idol",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    StatusId = table.Column<bool>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 200, nullable: true),
                    LastName = table.Column<string>(maxLength: 200, nullable: true),
                    MiddleName = table.Column<string>(maxLength: 200, nullable: true),
                    Age = table.Column<int>(nullable: true),
                    Sex = table.Column<bool>(nullable: false, defaultValue: false),
                    DateOfBirth = table.Column<DateTime>(nullable: true),
                    AvatarImage = table.Column<Guid>(nullable: true),
                    NickName = table.Column<string>(maxLength: 200, nullable: true),
                    Weight = table.Column<double>(nullable: false),
                    Height = table.Column<double>(nullable: false),
                    Star = table.Column<string>(maxLength: 200, nullable: true),
                    Habit = table.Column<string>(nullable: true),
                    BloodId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Idol", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Idol_Blood_BloodId",
                        column: x => x.BloodId,
                        principalTable: "Blood",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AttachmentFile",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    StatusId = table.Column<bool>(nullable: false),
                    ParentId = table.Column<Guid>(nullable: false),
                    FileName = table.Column<string>(nullable: true),
                    FileType = table.Column<string>(nullable: true),
                    FileExtension = table.Column<string>(nullable: true),
                    FileSize = table.Column<int>(nullable: false),
                    FileData = table.Column<byte[]>(nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    MovieId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttachmentFile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AttachmentFile_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MappingMovieCategory",
                columns: table => new
                {
                    MovieId = table.Column<Guid>(nullable: false),
                    CategoryId = table.Column<Guid>(nullable: false),
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    StatusId = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MappingMovieCategory", x => new { x.MovieId, x.CategoryId });
                    table.UniqueConstraint("AK_MappingMovieCategory_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MappingMovieCategory_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MappingMovieCategory_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SourceLink",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    StatusId = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: true),
                    Link = table.Column<string>(maxLength: 700, nullable: true),
                    DownloadLink = table.Column<string>(maxLength: 700, nullable: true),
                    Resolution = table.Column<string>(maxLength: 50, nullable: true),
                    Server = table.Column<string>(maxLength: 200, nullable: true),
                    MovieId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SourceLink", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SourceLink_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MappingAlbumIdol",
                columns: table => new
                {
                    AlbumId = table.Column<Guid>(nullable: false),
                    IdolId = table.Column<Guid>(nullable: false),
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    StatusId = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MappingAlbumIdol", x => new { x.AlbumId, x.IdolId });
                    table.UniqueConstraint("AK_MappingAlbumIdol_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MappingAlbumIdol_Album_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Album",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MappingAlbumIdol_Idol_IdolId",
                        column: x => x.IdolId,
                        principalTable: "Idol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MappingMovieIdol",
                columns: table => new
                {
                    MovieId = table.Column<Guid>(nullable: false),
                    IdolId = table.Column<Guid>(nullable: false),
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    StatusId = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MappingMovieIdol", x => new { x.MovieId, x.IdolId });
                    table.UniqueConstraint("AK_MappingMovieIdol_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MappingMovieIdol_Idol_IdolId",
                        column: x => x.IdolId,
                        principalTable: "Idol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MappingMovieIdol_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    StatusId = table.Column<bool>(nullable: false),
                    AltName = table.Column<string>(maxLength: 200, nullable: true),
                    Extension = table.Column<string>(maxLength: 20, nullable: true),
                    Size = table.Column<double>(nullable: false),
                    Height = table.Column<double>(nullable: false),
                    Width = table.Column<double>(nullable: false),
                    Link = table.Column<string>(maxLength: 500, nullable: true),
                    Description = table.Column<string>(maxLength: 2000, nullable: true),
                    AttachmentFileId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Image_AttachmentFile_AttachmentFileId",
                        column: x => x.AttachmentFileId,
                        principalTable: "AttachmentFile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserProfile",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    StatusId = table.Column<bool>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 200, nullable: true),
                    LastName = table.Column<string>(maxLength: 200, nullable: true),
                    MiddleName = table.Column<string>(maxLength: 200, nullable: true),
                    Email = table.Column<string>(maxLength: 200, nullable: true),
                    Age = table.Column<int>(nullable: true),
                    Sex = table.Column<bool>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: true),
                    AvatarImage = table.Column<Guid>(nullable: true),
                    AttachmentFileId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserProfile_AttachmentFile_AttachmentFileId",
                        column: x => x.AttachmentFileId,
                        principalTable: "AttachmentFile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MappingAlbumImage",
                columns: table => new
                {
                    AlbumId = table.Column<Guid>(nullable: false),
                    ImageId = table.Column<Guid>(nullable: false),
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    StatusId = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MappingAlbumImage", x => new { x.AlbumId, x.ImageId });
                    table.UniqueConstraint("AK_MappingAlbumImage_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MappingAlbumImage_Album_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Album",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MappingAlbumImage_Image_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Image",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MappingMovieImage",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    StatusId = table.Column<bool>(nullable: false),
                    MovieId = table.Column<Guid>(nullable: false),
                    ImageId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MappingMovieImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MappingMovieImage_Image_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Image",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MappingMovieImage_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MappingUserComment",
                columns: table => new
                {
                    UserProfileId = table.Column<Guid>(nullable: false),
                    CommentId = table.Column<Guid>(nullable: false),
                    Id = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    StatusId = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MappingUserComment", x => new { x.UserProfileId, x.CommentId });
                    table.UniqueConstraint("AK_MappingUserComment_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MappingUserComment_Comment_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MappingUserComment_UserProfile_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AttachmentFile_MovieId",
                table: "AttachmentFile",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Idol_BloodId",
                table: "Idol",
                column: "BloodId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_AttachmentFileId",
                table: "Image",
                column: "AttachmentFileId");

            migrationBuilder.CreateIndex(
                name: "IX_MappingAlbumIdol_IdolId",
                table: "MappingAlbumIdol",
                column: "IdolId");

            migrationBuilder.CreateIndex(
                name: "IX_MappingAlbumImage_ImageId",
                table: "MappingAlbumImage",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_MappingMovieCategory_CategoryId",
                table: "MappingMovieCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MappingMovieIdol_IdolId",
                table: "MappingMovieIdol",
                column: "IdolId");

            migrationBuilder.CreateIndex(
                name: "IX_MappingMovieImage_ImageId",
                table: "MappingMovieImage",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_MappingMovieImage_MovieId",
                table: "MappingMovieImage",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_MappingUserComment_CommentId",
                table: "MappingUserComment",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_SourceLink_MovieId",
                table: "SourceLink",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfile_AttachmentFileId",
                table: "UserProfile",
                column: "AttachmentFileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MappingAlbumIdol");

            migrationBuilder.DropTable(
                name: "MappingAlbumImage");

            migrationBuilder.DropTable(
                name: "MappingMovieCategory");

            migrationBuilder.DropTable(
                name: "MappingMovieIdol");

            migrationBuilder.DropTable(
                name: "MappingMovieImage");

            migrationBuilder.DropTable(
                name: "MappingUserComment");

            migrationBuilder.DropTable(
                name: "SourceLink");

            migrationBuilder.DropTable(
                name: "Studio");

            migrationBuilder.DropTable(
                name: "Album");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Idol");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "UserProfile");

            migrationBuilder.DropTable(
                name: "Blood");

            migrationBuilder.DropTable(
                name: "AttachmentFile");

            migrationBuilder.DropTable(
                name: "Movie");
        }
    }
}
