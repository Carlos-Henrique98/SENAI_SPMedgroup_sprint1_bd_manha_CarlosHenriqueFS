USE StoryTelling_Manha;

/* DML - LINGUAGEM DE MANIPULAÇÃO DE DADOS */



/*			TABELA CLINICA					   */

INSERT INTO T_Clinica VALUES('SP MEDICAL GROUP','Rua dos Medicos','1355987451127','112365-9654')
GO


/*			TABELA - ESPECIALIDADE				*/

INSERT INTO T_Especialidade VALUES('Cardiologista')
INSERT INTO T_Especialidade VALUES('Pediatra')
INSERT INTO T_Especialidade VALUES('Odontologico')
INSERT INTO T_Especialidade VALUES('Dermatologista')
GO

UPDATE T_Especialidade
SET NomeEspecialidade = 'Farmaceutico'
WHERE IdEspecialidade = 1;


/*			TABELA TIPOUSUARIO					*/

INSERT INTO T_TipoUsuario VALUES('Paciente')
INSERT INTO T_TipoUsuario VALUES('Medico')
INSERT INTO T_TipoUsuario VALUES('Medico')
INSERT INTO T_TipoUsuario VALUES('Paciente')
GO

/*			TABELA USUARIOS						*/
INSERT INTO T_Usuario VALUES('Camilo','Camilo2020@gmail.com','123Camilo','20000212',1)
INSERT INTO T_Usuario VALUES('Diana','Di20@gmail.com','Di2020','19900308',2)
INSERT INTO T_Usuario VALUES('Higor','Higao@gmail.com','h1230','19980416',3)
INSERT INTO T_Usuario VALUES('Vinicius','Vini19@yahoo.com','Mans1234','19950724',4)
GO

/*Quantidade de usuarios*/
SELECT COUNT(IdUsuario)AS "QuantidadeUsuarios" FROM T_Usuario 

/* Converter a data de nascimento do usuario*/
SELECT NomeUsuario, 
CAST(MONTH(NascimentoUsuario) AS VARCHAR) + '/' + 
CAST(DAY(NascimentoUsuario) AS VARCHAR) + '/' + 
CAST(YEAR(NascimentoUsuario) AS VARCHAR) AS "M/D/A"
FROM T_Usuario

/*Calcular a idade do usuario*/
SELECT NomeUsuario, DATEDIFF(YEAR,NascimentoUsuario, GETDATE()) AS "IDADE"
FROM T_Usuario
GO

/*			TABELA MEDICO						*/

INSERT INTO T_Medico VALUES('Helena Strada','023658965','Feminino',1,1,1)
INSERT INTO T_Medico VALUES('Carol Dantas','148569856','Feminino',2,2,2)
INSERT INTO T_Medico VALUES('Roberto Possarle','023542120','Masculino',3,3,3)
INSERT INTO T_Medico VALUES('Ricardo Lemos','049686321','Feminino',4,4,4)
GO


/*			TABELA PACIENTE						*/

INSERT INTO T_Paciente VALUES('Mariano','023490126','25698585411','Rua das Pitangas','20000312','Masculino','112314-9656',1)
INSERT INTO T_Paciente VALUES('Alexandre','093287424','32429889903','Rua dos Velhinhos','19990812','Masculino','112314-9656',2)
INSERT INTO T_Paciente VALUES('Fernanda','218932324','48090356889','Rua dos Marajas','19980314','Feminino','112314-9656',3)
INSERT INTO T_Paciente VALUES('Henrique','987435876','32498745688','Rua Morcegos Dourados','20010911','Masculino','112314-9656',4)
GO

/*			TABELA SITUACAO						*/

INSERT INTO T_Situacao VALUES('Realizada')
INSERT INTO T_Situacao VALUES('Cancelada')
INSERT INTO T_Situacao VALUES('Realizada')
INSERT INTO T_Situacao VALUES('Realizada')
INSERT INTO T_Situacao VALUES('Cancelada')
INSERT INTO T_Situacao VALUES('Agendada')
INSERT INTO T_Situacao VALUES('Agendada')

/*			TABELA CONSULTA						*/

/*Deletar os dados que não possuem data de cadastro*/
--SELECT 

INSERT INTO T_Consulta VALUES('20200120',1,1,1)
INSERT INTO T_Consulta VALUES('20200106',2,2,2)
INSERT INTO T_Consulta VALUES('20200207',3,3,3)
INSERT INTO T_Consulta VALUES('20180206',4,4,4)
INSERT INTO T_Consulta VALUES('20190207',5,5,5)
INSERT INTO T_Consulta VALUES('20200308',6,6,6)
INSERT INTO T_Consulta VALUES('20200309',7,7,7)
GO

/*			TABELA ADM							*/

INSERT INTO T_ADM VALUES(1)
INSERT INTO T_ADM VALUES(2)
INSERT INTO T_ADM VALUES(3)
INSERT INTO T_ADM VALUES(4)

/*Criar uma função para retornar a quantidade de médicos*/
SELECT COUNT(IdMedico) AS "QtdMedicos"
FROM T_Medico M INNER JOIN T_Especialidade E ON M.IdEspecialidade = E.IdEspecialidade
WHERE NomeEspecialidade = 'Cardiologista';

/*Criou uma função para que retorne à idade do usuário a partir de uma determinada stored procedure*/
CREATE PROCEDURE P_Usuario
AS
SELECT DATEDIFF(YEAR,NascimentoUsuario, GETDATE()) AS "Idade"
FROM T_Usuario

EXEC P_Usuario 


SELECT * FROM T_Clinica;
SELECT * FROM T_Especialidade;
SELECT * FROM T_Paciente;
SELECT * FROM  T_TipoUsuario;
SELECT * FROM T_Usuario;
SELECT * FROM T_ADM;
SELECT * FROM T_Situacao;

/**/
SELECT * FROM T_Consulta;
/**/
SELECT * FROM T_Medico;

TRUNCATE TABLE T_Consulta;