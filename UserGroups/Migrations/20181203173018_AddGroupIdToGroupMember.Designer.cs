﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UserGroups.Models;

namespace UserGroups.Migrations
{
    [DbContext(typeof(UserGroupsContext))]
    [Migration("20181203173018_AddGroupIdToGroupMember")]
    partial class AddGroupIdToGroupMember
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("UserGroups.Models.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Group");
                });

            modelBuilder.Entity("UserGroups.Models.GroupMember", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("GroupId");

                    b.Property<int>("Type");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(36);

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("GroupMember");
                });

            modelBuilder.Entity("UserGroups.Models.GroupMember", b =>
                {
                    b.HasOne("UserGroups.Models.Group")
                        .WithMany("Members")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
