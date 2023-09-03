﻿// <auto-generated />
using System;
using Crypton.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Crypton.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("00000000000002_AddOutbox")]
    partial class AddOutbox
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0-preview.7.23375.4");

            modelBuilder.Entity("Crypton.Domain.Entities.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("id");

                    b.Property<string>("ItemTypeId")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("item_type_id");

                    b.Property<Guid>("OwnerId")
                        .HasColumnType("TEXT")
                        .HasColumnName("owner_id");

                    b.HasKey("Id")
                        .HasName("pk_item");

                    b.HasIndex("ItemTypeId")
                        .HasDatabaseName("ix_item_item_type_id");

                    b.HasIndex("OwnerId")
                        .HasDatabaseName("ix_item_owner_id");

                    b.ToTable("item");
                });

            modelBuilder.Entity("Crypton.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("id");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER")
                        .HasColumnName("access_failed_count");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT")
                        .HasColumnName("concurrency_stamp");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("TEXT")
                        .HasColumnName("created");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT")
                        .HasColumnName("created_by");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("TEXT")
                        .HasColumnName("deleted");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("TEXT")
                        .HasColumnName("deleted_by");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT")
                        .HasColumnName("email");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER")
                        .HasColumnName("email_confirmed");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("TEXT")
                        .HasColumnName("last_modified");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("TEXT")
                        .HasColumnName("last_modified_by");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER")
                        .HasColumnName("lockout_enabled");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT")
                        .HasColumnName("lockout_end");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT")
                        .HasColumnName("normalized_email");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT")
                        .HasColumnName("normalized_user_name");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT")
                        .HasColumnName("password_hash");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT")
                        .HasColumnName("phone_number");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER")
                        .HasColumnName("phone_number_confirmed");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT")
                        .HasColumnName("security_stamp");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER")
                        .HasColumnName("two_factor_enabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT")
                        .HasColumnName("user_name");

                    b.Property<decimal>("Wallet")
                        .HasColumnType("TEXT")
                        .HasColumnName("wallet");

                    b.HasKey("Id")
                        .HasName("pk_user");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("email_index");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("user_name_index");

                    b.HasIndex("UserName")
                        .IsUnique()
                        .HasDatabaseName("ix_user_user_name");

                    b.ToTable("user", (string)null);
                });

            modelBuilder.Entity("Crypton.Domain.ValueObjects.ItemType", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT")
                        .HasColumnName("id");

                    b.Property<float>("MaxRarity")
                        .HasColumnType("REAL")
                        .HasColumnName("max_rarity");

                    b.Property<float>("MinRarity")
                        .HasColumnType("REAL")
                        .HasColumnName("min_rarity");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT")
                        .HasColumnName("price");

                    b.HasKey("Id")
                        .HasName("pk_item_type");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasDatabaseName("ix_item_type_name");

                    b.ToTable("item_type");

                    b.HasData(
                        new
                        {
                            Id = "FISHING_ROD",
                            MaxRarity = 0.9f,
                            MinRarity = 0.1f,
                            Name = "Fishing rod 🎣",
                            Price = 75m
                        },
                        new
                        {
                            Id = "HUNTING_RIFLE",
                            MaxRarity = 0.9f,
                            MinRarity = 0.1f,
                            Name = "Hunting Rifle 🔫",
                            Price = 75m
                        },
                        new
                        {
                            Id = "SHOVEL",
                            MaxRarity = 0.9f,
                            MinRarity = 0.1f,
                            Name = "Shovel 🪣",
                            Price = 75m
                        },
                        new
                        {
                            Id = "COMMON_FISH",
                            MaxRarity = 0.9f,
                            MinRarity = 0.1f,
                            Name = "Common Fish 🐟",
                            Price = 5m
                        },
                        new
                        {
                            Id = "RARE_FISH",
                            MaxRarity = 0.9f,
                            MinRarity = 0.1f,
                            Name = "Rare Fish 🐡",
                            Price = 10m
                        },
                        new
                        {
                            Id = "TROPICAL_FISH",
                            MaxRarity = 0.9f,
                            MinRarity = 0.1f,
                            Name = "Tropical Fish 🐯",
                            Price = 20m
                        },
                        new
                        {
                            Id = "SHARK",
                            MaxRarity = 0.9f,
                            MinRarity = 0.1f,
                            Name = "Shark 🐠",
                            Price = 40m
                        },
                        new
                        {
                            Id = "GOLDEN_FISH",
                            MaxRarity = 0.9f,
                            MinRarity = 0.1f,
                            Name = "Golden Fish 🦈",
                            Price = 50m
                        },
                        new
                        {
                            Id = "PIG",
                            MaxRarity = 0.9f,
                            MinRarity = 0.1f,
                            Name = "Pig 🥇🐟",
                            Price = 5m
                        },
                        new
                        {
                            Id = "DEER",
                            MaxRarity = 0.9f,
                            MinRarity = 0.1f,
                            Name = "Deer 🐷",
                            Price = 10m
                        },
                        new
                        {
                            Id = "BEAR",
                            MaxRarity = 0.9f,
                            MinRarity = 0.1f,
                            Name = "Bear 🦌",
                            Price = 20m
                        },
                        new
                        {
                            Id = "WOLF",
                            MaxRarity = 0.9f,
                            MinRarity = 0.1f,
                            Name = "Wolf 🐺",
                            Price = 30m
                        },
                        new
                        {
                            Id = "TIGER",
                            MaxRarity = 0.9f,
                            MinRarity = 0.1f,
                            Name = "Tiger 🐻",
                            Price = 40m
                        },
                        new
                        {
                            Id = "LION",
                            MaxRarity = 0.9f,
                            MinRarity = 0.1f,
                            Name = "Lion 🦁",
                            Price = 50m
                        },
                        new
                        {
                            Id = "ELEPHANT",
                            MaxRarity = 0.9f,
                            MinRarity = 0.1f,
                            Name = "Elephant 🐯",
                            Price = 60m
                        },
                        new
                        {
                            Id = "COPPER_COIN",
                            MaxRarity = 0.9f,
                            MinRarity = 0.1f,
                            Name = "Copper Coin 🐘",
                            Price = 1m
                        },
                        new
                        {
                            Id = "EMERALD",
                            MaxRarity = 0.9f,
                            MinRarity = 0.1f,
                            Name = "Emerald 👛",
                            Price = 10m
                        },
                        new
                        {
                            Id = "RUBY",
                            MaxRarity = 0.9f,
                            MinRarity = 0.1f,
                            Name = "Ruby 🔶",
                            Price = 20m
                        },
                        new
                        {
                            Id = "SAPPHIRE",
                            MaxRarity = 0.9f,
                            MinRarity = 0.1f,
                            Name = "Sapphire 🔷",
                            Price = 30m
                        },
                        new
                        {
                            Id = "AMETHYST",
                            MaxRarity = 0.9f,
                            MinRarity = 0.1f,
                            Name = "Amethyst 🔴",
                            Price = 40m
                        },
                        new
                        {
                            Id = "DIAMOND",
                            MaxRarity = 0.9f,
                            MinRarity = 0.1f,
                            Name = "Diamond 💎",
                            Price = 50m
                        },
                        new
                        {
                            Id = "KNIFE",
                            MaxRarity = 0.9f,
                            MinRarity = 0.1f,
                            Name = "Knife 🔪",
                            Price = 50m
                        },
                        new
                        {
                            Id = "WEDDING_RING",
                            MaxRarity = 0.9f,
                            MinRarity = 0.1f,
                            Name = "Wedding Ring 💍",
                            Price = 1000m
                        });
                });

            modelBuilder.Entity("Crypton.Infrastructure.Persistence.Common.OutboxMessage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("id");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("content");

                    b.Property<string>("Error")
                        .HasColumnType("TEXT")
                        .HasColumnName("error");

                    b.Property<DateTime>("OccuredOnUtc")
                        .HasColumnType("TEXT")
                        .HasColumnName("occured_on_utc");

                    b.Property<DateTime?>("ProcessedOnUtc")
                        .HasColumnType("TEXT")
                        .HasColumnName("processed_on_utc");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("type");

                    b.HasKey("Id")
                        .HasName("pk_outbox_message");

                    b.ToTable("outbox_message");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasColumnName("id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT")
                        .HasColumnName("concurrency_stamp");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT")
                        .HasColumnName("normalized_name");

                    b.HasKey("Id")
                        .HasName("pk_role");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("role_name_index");

                    b.ToTable("role", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT")
                        .HasColumnName("claim_type");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT")
                        .HasColumnName("claim_value");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("TEXT")
                        .HasColumnName("role_id");

                    b.HasKey("Id")
                        .HasName("pk_role_claim");

                    b.HasIndex("RoleId")
                        .HasDatabaseName("ix_role_claim_role_id");

                    b.ToTable("role_claim", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT")
                        .HasColumnName("claim_type");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT")
                        .HasColumnName("claim_value");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("pk_user_claim");

                    b.HasIndex("UserId")
                        .HasDatabaseName("ix_user_claim_user_id");

                    b.ToTable("user_claim", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT")
                        .HasColumnName("login_provider");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT")
                        .HasColumnName("provider_key");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT")
                        .HasColumnName("provider_display_name");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT")
                        .HasColumnName("user_id");

                    b.HasKey("LoginProvider", "ProviderKey")
                        .HasName("pk_user_login");

                    b.HasIndex("UserId")
                        .HasDatabaseName("ix_user_login_user_id");

                    b.ToTable("user_login", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT")
                        .HasColumnName("user_id");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("TEXT")
                        .HasColumnName("role_id");

                    b.HasKey("UserId", "RoleId")
                        .HasName("pk_user_role");

                    b.HasIndex("RoleId")
                        .HasDatabaseName("ix_user_role_role_id");

                    b.ToTable("user_role", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT")
                        .HasColumnName("user_id");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT")
                        .HasColumnName("login_provider");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT")
                        .HasColumnName("value");

                    b.HasKey("UserId", "LoginProvider", "Name")
                        .HasName("pk_user_token");

                    b.ToTable("user_token", (string)null);
                });

            modelBuilder.Entity("Crypton.Domain.Entities.Item", b =>
                {
                    b.HasOne("Crypton.Domain.ValueObjects.ItemType", "ItemType")
                        .WithMany()
                        .HasForeignKey("ItemTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_item_item_types_item_type_id");

                    b.HasOne("Crypton.Domain.Entities.User", "Owner")
                        .WithMany("Inventory")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_item_asp_net_users_owner_id");

                    b.Navigation("ItemType");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Crypton.Domain.Entities.User", b =>
                {
                    b.OwnsOne("Crypton.Domain.ValueObjects.DailyStreak", "DailyStreak", b1 =>
                        {
                            b1.Property<Guid>("id")
                                .HasColumnType("TEXT")
                                .HasColumnName("id");

                            b1.Property<DateTime>("DailyCollectedAt")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("TEXT")
                                .HasDefaultValue(new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc))
                                .HasColumnName("daily_collected_at");

                            b1.Property<int>("Streak")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("INTEGER")
                                .HasDefaultValue(0)
                                .HasColumnName("streak");

                            b1.HasKey("id")
                                .HasName("pk_user");

                            b1.ToTable("user");

                            b1.WithOwner()
                                .HasForeignKey("id")
                                .HasConstraintName("fk_user_user_id");
                        });

                    b.Navigation("DailyStreak")
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_role_claim_role_role_id");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("Crypton.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_user_claim_user_user_id");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("Crypton.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_user_login_user_user_id");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_user_role_role_role_id");

                    b.HasOne("Crypton.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_user_role_user_user_id");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("Crypton.Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_user_token_user_user_id");
                });

            modelBuilder.Entity("Crypton.Domain.Entities.User", b =>
                {
                    b.Navigation("Inventory");
                });
#pragma warning restore 612, 618
        }
    }
}
