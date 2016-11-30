--------------------------------------------------------------------------------------------------------------------------
-- ���� ������ ��������� �����, �� � ������� ����� ��������� ����������� ����������� �� -1:				+				--
--------------------------------------------------------------------------------------------------------------------------
	CREATE TRIGGER Delete_Instances ON Instances
	AFTER DELETE
	AS

	DECLARE @ISBN nchar(13)
	
	SELECT @ISBN = ISBN FROM DELETED
	
	UPDATE Books  
	SET number = number - 1
	WHERE ISBN = @ISBN