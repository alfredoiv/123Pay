using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _123Pay.Migrations
{
    public partial class spUpdateAttachmentStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			string procedure = @"CREATE PROCEDURE [dbo].[spUpdateAttachmentStatus]
									@ID AS INT,
									@AttachmentFilePath AS NVARCHAR(MAX),
									@Status AS NVARCHAR(255),
									@ProcessorID as nvarchar(450)
								AS
								BEGIN
									SET NOCOUNT ON;
									BEGIN TRANSACTION;
									BEGIN TRY
										UPDATE [dbo].[PaymentRequests] SET
											[AttachmentFilePath] = @AttachmentFilePath,
											[Status] = @Status,
											[ProcessorId] = @ProcessorID
										WHERE ID = @ID
									END TRY
									BEGIN CATCH

										SELECT  ERROR_NUMBER() AS errorNumber
												,ERROR_SEVERITY() AS errorSeverity
												,ERROR_STATE() AS errorState
												,ERROR_PROCEDURE() AS errorProcedure
												,ERROR_LINE() AS errorLine
												,ERROR_MESSAGE() AS errorMessage;

										IF @@TRANCOUNT > 0
											ROLLBACK TRANSACTION;

									END CATCH;

									IF @@TRANCOUNT > 0
										COMMIT TRANSACTION;
								END";
			migrationBuilder.Sql(procedure);

		}

        protected override void Down(MigrationBuilder migrationBuilder)
        {
			string procedure = "DROP PROCEDURE [dbo].[spUpdateAttachmentStatus]";
			migrationBuilder.Sql(procedure);
		}
    }
}
