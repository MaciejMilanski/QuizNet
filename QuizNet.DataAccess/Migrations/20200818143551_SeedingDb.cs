using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizNet.DataAccess.Migrations
{
    public partial class SeedingDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@" -- First question
                 INSERT INTO Questions (CONTENT, CREATION_TIME) VALUES (N'Życie jest tylko przechodnim półcieniem - Skąd to cytat?', GETDATE())
                 DECLARE @questionId as int = SCOPE_IDENTITY()
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES (N'Dziady', @questionId, 0, GETDATE())
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES (N'Makbet', @questionId, 1, GETDATE())
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES (N'Lalka', @questionId, 0, GETDATE())
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES (N'Dżuma', @questionId, 0, GETDATE())

                 --Second question
                 INSERT INTO Questions (CONTENT, CREATION_TIME) VALUES (N'Opus Magnum C++ - Kto napisał tę książkę? ', GETDATE())
                 SET @questionId = SCOPE_IDENTITY()
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES (N'Arthur Clark', @questionId, 0, GETDATE())
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES (N'Jeremy Clarkson', @questionId, 0, GETDATE())
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES (N'Jerzy Grębosz', @questionId, 1, GETDATE())
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES (N'Andrzej Pilipiuk', @questionId, 0, GETDATE())

                 --Third question
                 INSERT INTO Questions (CONTENT, CREATION_TIME) VALUES (N'Jaki jest najlepszy język programowania? ', GETDATE())
                 SET @questionId = SCOPE_IDENTITY()
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES (N'C++', @questionId, 0, GETDATE())
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES (N'Java', @questionId, 0, GETDATE())
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES (N'JavaScript', @questionId, 0, GETDATE())
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES (N'C#', @questionId, 1, GETDATE())

                 --Fourth question
                 INSERT INTO Questions (CONTENT, CREATION_TIME) VALUES (N'Dokąd nocą tupta jeż?', GETDATE())
                 SET @questionId = SCOPE_IDENTITY()
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES (N'Do jeżycy', @questionId, 0, GETDATE())
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES (N'Do warsztatu', @questionId, 0, GETDATE())
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES (N'Do domu', @questionId, 0, GETDATE())
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES (N'Do Galerii Zaspa', @questionId, 1, GETDATE())

                 --Fifth question
                 INSERT INTO Questions (CONTENT, CREATION_TIME) VALUES (N'Która metoda HTTP służy do wysłania informacji z formularza znajdujacego sie na stronie internetowej? ', GETDATE())
                 SET @questionId = SCOPE_IDENTITY()
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES (N'GET', @questionId, 0, GETDATE())
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES (N'PUT', @questionId, 0, GETDATE())
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES (N'POST', @questionId, 1, GETDATE())
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES (N'ROUTE', @questionId, 0, GETDATE())

                 -- Sixth question
                 INSERT INTO Questions (CONTENT, CREATION_TIME) VALUES (N'Do czego służa ciasteczka? ', GETDATE())
                 SET @questionId = SCOPE_IDENTITY()
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES (N'Do jedzenia', @questionId, 0, GETDATE())
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES (N'Do zapisywania ustawien witryn', @questionId, 1, GETDATE())
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES (N'Do rzucania w kolegów', @questionId, 0, GETDATE())
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES (N'Do komunikacji między serwerem a klientem', @questionId, 0, GETDATE())"
                );

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "DELETE FROM Questions" +
                "DELETE FROM Answers"
                );

        }
    }
}
