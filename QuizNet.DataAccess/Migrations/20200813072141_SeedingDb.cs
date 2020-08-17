using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizNet.DataAccess.Migrations
{
    public partial class SeedingDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@" -- First question
                 INSERT INTO Questions (CONTENT, CREATION_TIME) VALUES ('Zycie jest tylko przechodnim pólcieniem - Skad to cytat?', GETDATE())
                 DECLARE @questionId as int = SCOPE_IDENTITY()
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES ('Dziady', @questionId, 0, GETDATE())
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES ('Makbet', @questionId, 1, GETDATE())
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES ('Lalka', @questionId, 0, GETDATE())
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES ('Dzuma', @questionId, 0, GETDATE())

                 --Second question
                 INSERT INTO Questions (CONTENT, CREATION_TIME) VALUES ('Opus Magnum C++ - Kto napisal te ksiazke ', GETDATE())
                 SET @questionId = SCOPE_IDENTITY()
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES ('Arthur Clark', @questionId, 0, GETDATE())
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES ('Jeremy Clarkson', @questionId, 0, GETDATE())
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES ('Jerzy Grębosz', @questionId, 1, GETDATE())
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES ('Andrzej Pilipiuk', @questionId, 0, GETDATE())

                 --Third question
                 INSERT INTO Questions (CONTENT, CREATION_TIME) VALUES ('Jaki jest najlepszy jezyk programowania? ', GETDATE())
                 SET @questionId = SCOPE_IDENTITY()
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES ('C++', @questionId, 0, GETDATE())
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES ('Java', @questionId, 0, GETDATE())
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES ('JavaScript', @questionId, 0, GETDATE())
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES ('C#', @questionId, 1, GETDATE())

                 --Fourth question
                 INSERT INTO Questions (CONTENT, CREATION_TIME) VALUES ('Dokad noca tupta jez ', GETDATE())
                 SET @questionId = SCOPE_IDENTITY()
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES ('Do jezycy', @questionId, 0, GETDATE())
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES ('Do warsztatu', @questionId, 0, GETDATE())
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES ('Do domu', @questionId, 0, GETDATE())
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES ('Do Galerii Zaspa', @questionId, 1, GETDATE())

                 --Fifth question
                 INSERT INTO Questions (CONTENT, CREATION_TIME) VALUES ('Która metoda HTTP sluzy do wyslania informacji z formularza znajdujacego sie na stronie internetowej ', GETDATE())
                 SET @questionId = SCOPE_IDENTITY()
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES ('GET', @questionId, 0, GETDATE())
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES ('PUT', @questionId, 0, GETDATE())
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES ('POST', @questionId, 1, GETDATE())
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES ('ROUTE', @questionId, 0, GETDATE())

                 -- Sixth question
                 INSERT INTO Questions (CONTENT, CREATION_TIME) VALUES ('Do czego sluza ciasteczka? ', GETDATE())
                 SET @questionId = SCOPE_IDENTITY()
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES ('Do jedzenia', @questionId, 0, GETDATE())
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES ('Do zapisywania ustawien witryn', @questionId, 1, GETDATE())
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES ('Do rzucania w kolegów', @questionId, 0, GETDATE())
                 INSERT INTO Answers (CONTENT, QUESTION_ID, IS_CORRECT, CREATION_TIME) VALUES ('Do komunikacji między serwerem a klientem', @questionId, 0, GETDATE())"
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
