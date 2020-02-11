USE StoryTelling_Manha;

/* DML - LINGUAGEM DE MANIPULAÇÃO DE DADOS */

INSERT INTO T_Clinica VALUES('SP MEDICAL GROUP','Rua dos Medicos','1355987451127','112365-9654')

INSERT INTO T_Medico VALUES('Rodholfo','023658965','Masculino')
INSERT INTO T_Medico VALUES('Maria','148569856','Feminino')
INSERT INTO T_Medico VALUES('Marlin','023542120','Masculino')
INSERT INTO T_Medico VALUES('Rebeca','049686321','Feminino')

INSERT INTO T_Paciente VALUES('Ronaldo','Rua das Pitangas','Masculino','112314-9656')
INSERT INTO T_Paciente VALUES('Maria','Rua dos Velhinhos','Feminino','112314-9656')
INSERT INTO T_Paciente VALUES('Debora','Rua dos Marajas','Feminino','112314-9656')
INSERT INTO T_Paciente VALUES('Jeilton','Rua Morcegos Dourados','Masculino','112314-9656')

INSERT INTO T_TipoUsuario VALUES('Paciente',1)
INSERT INTO T_TipoUsuario VALUES('Medico',2)
INSERT INTO T_TipoUsuario VALUES('Medico',3)
INSERT INTO T_TipoUsuario VALUES('Paciente',4)

INSERT INTO T_Usuario VALUES('Camilo','Masculino','112365-9658',1)
INSERT INTO T_Usuario VALUES('Diana','Feminino','11 2365-9632',2)
INSERT INTO T_Usuario VALUES('Higor','Masculino','11 1254-8965',3)
INSERT INTO T_Usuario VALUES('Vinicius','Masculino','11 1362-9632',4)

INSERT INTO T_Consulta VALUES('Cardiologista','20200522',1,1)
INSERT INTO T_Consulta VALUES('Pediatra','20200326',2,2)
INSERT INTO T_Consulta VALUES('Massagista','20200908',3,3)
INSERT INTO T_Consulta VALUES('Dentista','20210407',4,4)
