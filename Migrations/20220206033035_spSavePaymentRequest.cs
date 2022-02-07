using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _123Pay.Migrations
{
    public partial class spSavePaymentRequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			string procedure = @"CREATE PROCEDURE [dbo].[spSavePaymentRequest]
									@ClientName AS NVARCHAR(255), 
									@CustomerName AS NVARCHAR(255), 
									@ReferenceNo AS NVARCHAR(255), 
									@Merchant AS NVARCHAR(255), 
									@AccountNo AS NVARCHAR(255), 
									@AccountName AS NVARCHAR(255), 
									@OtherDetails AS NVARCHAR(255), 
									@Amount AS FLOAT
								AS
								BEGIN
									SET NOCOUNT ON;
									BEGIN TRANSACTION;
									BEGIN TRY
										INSERT INTO [dbo].[PaymentRequests] ([CreateDate], [Status], [ClientName], [CustomerName], [ReferenceNo], [Merchant], [AccountNo], [AccountName], [OtherDetails], [Amount])
										SELECT GETDATE(), 'PENDING', @ClientName, @CustomerName, @ReferenceNo, @Merchant, @AccountNo, @AccountName, @OtherDetails, @Amount
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
								END	";

			migrationBuilder.Sql(procedure);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
			string procedure = @"DROP PROCEDURE [dbo].[spSavePaymentRequest]";
			migrationBuilder.Sql(procedure);

		}
    }
}
