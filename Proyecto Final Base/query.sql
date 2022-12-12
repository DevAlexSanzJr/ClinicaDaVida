--- Scripts para SQL Server ---

--- CREAR LA BASE DE DATOS ---
CREATE DATABASE ClinicaMedica_DaVida;

--- USAR LA BASE DE DATOS ---
USE ClinicaMedica_DaVida;

--- TABLAS Y PROCEDIMIENTOS ---
--- ADMINISTRADOR ---
CREATE TABLE Administrador(
	id INT PRIMARY KEY IDENTITY(1, 1) NOT NULL,
	nombreUsuario VARCHAR(50) NOT NULL,
	password VARCHAR(200) NOT NULL
);

--- PACIENTES ---
CREATE TABLE Pacientes(
	id INT PRIMARY KEY IDENTITY(1, 1) NOT NULL,
	nombre VARCHAR(100) NOT NULL,
	edad INT NOT NULL,
	genero VARCHAR(20),
	codigo VARCHAR(50) NOT NULL,
);
--- MOSTRAR ---
CREATE PROC MostrarPacientes
AS
SELECT * FROM Pacientes;
--- INSERTAR ---
CREATE PROC CrearPaciente
@nombre VARCHAR(100),
@edad INT,
@genero VARCHAR(20),
@codigo VARCHAR(50)
AS
INSERT Pacientes VALUES (@nombre, @edad, @genero, @codigo);
--- EDITAR ---
CREATE PROC EditarPaciente
@nombre VARCHAR(100),
@edad INT,
@genero VARCHAR(20),
@codigo VARCHAR(50),
@id INT
AS
UPDATE Pacientes SET nombre=@nombre, edad=@edad, genero=@genero, codigo=@codigo WHERE id=@id;
--- ELIMINAR ---
CREATE PROC EliminarPaciente
@id INT
AS
DELETE FROM Pacientes WHERE id=@id

--- MEDICAMENTOS ---
CREATE TABLE Medicamentos(
	id INT PRIMARY KEY IDENTITY(1, 1) NOT NULL,
	nombre VARCHAR(100) NOT NULL,
	descripcion VARCHAR(200) NOT NULL,
	efectosSecundarios VARCHAR(200) NOT NULL,
	marca VARCHAR(50) NOT NULL
);
--- MOSTRAR ---
CREATE PROC MostrarMedicamentos
AS
SELECT * FROM Medicamentos;
---INSERTAR ---
CREATE PROC CrearMedicamento
@nombre VARCHAR(100),
@descrip VARCHAR(200),
@efectosSec VARCHAR(200),
@marca VARCHAR(50)
AS
INSERT Medicamentos VALUES (@nombre,@descrip, @efectosSec,@marca);
--- EDITAR ---
CREATE PROC EditarMedicamento
@nombre VARCHAR(100),
@descrip VARCHAR(200),
@efectosSec VARCHAR(200),
@marca VARCHAR(50),
@id INT
AS
UPDATE Medicamentos SET nombre=@nombre, descripcion=@descrip, efectosSecundarios=@efectosSec, marca=@marca WHERE id=@id;
--- ELIMINAR ---
CREATE PROC EliminarMedicamento
@id INT
AS
DELETE FROM Medicamentos WHERE id=@id;

--- MEDICOS ---
CREATE TABLE Medicos(
	id INT PRIMARY KEY IDENTITY(1, 1) NOT NULL,
	nombre VARCHAR(100) NOT NULL,
	edad INT NOT NULL,
	genero VARCHAR(20),
	especialidad VARCHAR(50) NOT NULL,
	codigo VARCHAR(50) NOT NULL,
	contraMedico VARCHAR(200) NOT NULL,
);
--- MOSTRAR ---
CREATE PROC MostrarMedicos
AS
SELECT * FROM Medicos;
--- INSERTAR ---
CREATE PROC CrearMedico
@nombre VARCHAR(100),
@edad INT,
@genero VARCHAR(20),
@especialidad VARCHAR(50),
@codigo VARCHAR(50),
@contraMedico VARCHAR(200)
AS
INSERT Medicos VALUES (@nombre,@edad,@genero,@especialidad,@codigo,@contraMedico);
--- EDITAR ---
CREATE PROC EditarMedico
@nombre VARCHAR(100),
@edad INT,
@genero VARCHAR(20),
@especialidad VARCHAR(50),
@codigo VARCHAR(50),
@contraMedico VARCHAR(200),
@id INT
AS
UPDATE Medicos SET nombre=@nombre, edad=@edad, genero=@genero, especialidad=@especialidad, codigo=@codigo, contraMedico=@contraMedico WHERE id=@id;
--- ELIMINAR ---
CREATE PROC EliminarMedico
@id INT
AS
DELETE FROM Medicos WHERE id=@id;

--- ENFERMEROS ---
CREATE TABLE Enfermeros(
	id INT PRIMARY KEY IDENTITY(1, 1) NOT NULL,
	nombre VARCHAR(100) NOT NULL,
	edad INT NOT NULL,
	genero VARCHAR(20),
	codigo VARCHAR(50) NOT NULL,
	contraEnfermero VARCHAR(200) NOT NULL,
);
--- MOSTRAR ---
CREATE PROC MostrarEnfermeros
AS
SELECT * FROM Enfermeros;
--- INSERTAR ---
CREATE PROC CrearEnfermero
@nombre VARCHAR(100),
@edad INT,
@genero VARCHAR(20),
@codigo VARCHAR(50),
@contraEnfermero VARCHAR(200)
AS
INSERT Enfermeros VALUES (@nombre, @edad,@genero,@codigo,@contraEnfermero);
--- EDITAR ---
CREATE PROC EditarEnfermero
@nombre VARCHAR(100),
@edad INT,
@genero VARCHAR(20),
@codigo VARCHAR(50),
@contraEnfermero VARCHAR(200),
@id INT
AS
UPDATE Enfermeros SET nombre=@nombre, edad=@edad, genero=@genero, codigo=@codigo, contraEnfermero=@contraEnfermero WHERE id=@id;
--- ELIMINAR ---
CREATE PROC EliminarEnfermero
@id INT
AS
DELETE FROM Enfermeros WHERE id=@id;

--- CONSULTAS ---
CREATE TABLE RegistroConsultas (
	id INT PRIMARY KEY IDENTITY(1, 1) NOT NULL,
	nombrePaciente VARCHAR(50) NOT NULL,
	nombreMedico VARCHAR(50) NOT NULL,
	descripcion VARCHAR(200) NOT NULL,
	medicamento_Uno VARCHAR(100),
	medicamento_Dos VARCHAR(100),
	medicamento_Tres VARCHAR(100),
	medicamento_Cuatro VARCHAR(100),
	diagnostico VARCHAR(200) 
);

--- MOSTRAR ---
CREATE PROC MostrarConsultaEnfermero
AS
SELECT id, nombrePaciente, nombreMedico, descripcion FROM RegistroConsultas;
--- MOSTRAR DOCTORES EN ENFERMEROS ---
CREATE PROC MostrarMedicosEnfermeros
AS
SELECT id, nombre, especialidad, codigo FROM Medicos;
--- INSERTAR ---
CREATE PROC CrearConsultaEnfermero
@nombrePaciente VARCHAR(50),
@nombreMedico VARCHAR(50),
@descripcion VARCHAR(200)
AS
INSERT RegistroConsultas VALUES (@nombrePaciente, @nombreMedico, @descripcion, '', '', '', '', '');
--- EDITAR ---
CREATE PROC EditarConsultaEnfermero
@nombrePaciente VARCHAR(50),
@nombreMedico VARCHAR(50),
@descripcion VARCHAR(200),
@id INT
AS
UPDATE RegistroConsultas SET nombrePaciente=@nombrePaciente, nombreMedico=@nombreMedico, descripcion=@descripcion WHERE id=@id;
--- ELIMINAR ---
CREATE PROC EliminarConsultaEnfermero
@id INT
AS
DELETE FROM RegistroConsultas WHERE id=@id

--- PROCEDIMIENTOS ALMACENADOS DE MÉDICO ---
	CREATE TABLE Diagnostico (
		id INT PRIMARY KEY IDENTITY(1, 1) NOT NULL,
		nombrePaciente VARCHAR(50) NOT NULL,
		nombreMedico VARCHAR(50) NOT NULL,
		descripcion VARCHAR(200) NOT NULL,
		diagnostico VARCHAR(200),
		medicamento_Uno VARCHAR(100),
		medicamento_Dos VARCHAR(100),
		medicamento_Tres VARCHAR(100),
		medicamento_Cuatro VARCHAR(100)
	);
--- MOSTRAR ---
CREATE PROC MostrarDiagnostico
AS
SELECT * FROM Diagnostico;
--- INSERTAR ---
CREATE PROC CrearDiagnostico
@nombrePaciente VARCHAR(50),
@nombreMedico VARCHAR(50),
@descripcion VARCHAR(200),
@diagnostico VARCHAR(200),
@medicamentoUno VARCHAR(100),
@medicamentoDos VARCHAR(100),
@medicamentoTres VARCHAR(100),
@medicamentoCuatro VARCHAR(100)
AS
INSERT Diagnostico VALUES (@nombrePaciente, @nombreMedico, @descripcion, @diagnostico, @medicamentoUno, @medicamentoDos, @medicamentoTres, @medicamentoCuatro);
--- EDITAR ---
CREATE PROC EditarDiagnostico
@nombrePaciente VARCHAR(50),
@nombreMedico VARCHAR(50),
@descripcion VARCHAR(200),
@diagnostico VARCHAR(200),
@medicamentoUno VARCHAR(100),
@medicamentoDos VARCHAR(100),
@medicamentoTres VARCHAR(100),
@medicamentoCuatro VARCHAR(100),
@id INT
AS
UPDATE Diagnostico SET nombrePaciente=@nombrePaciente, nombreMedico=@nombreMedico, descripcion=@descripcion, diagnostico=@diagnostico, @medicamentoUno=@medicamentoUno, @medicamentoDos=@medicamentoDos, @medicamentoTres=@medicamentoTres, medicamento_Cuatro=@medicamentoCuatro WHERE id=@id;
--- ELIMINAR ---
CREATE PROC EliminarDiagnostico
@id INT
AS
DELETE FROM Diagnostico WHERE id=@id

---  ENTIDAD RELACIÓN ---
CREATE TABLE Consultas (
	id INT PRIMARY KEY IDENTITY(1, 1) NOT NULL,
	idPaciente INT,
	idMedico INT,
	medicamento_Uno INT,
	medicamento_Dos INT,
	medicamento_Tres INT,
	medicamento_Cuatro INT,
	descripcion VARCHAR(200) NOT NULL,
	diagnostico VARCHAR(200) NOT NULL,
	FOREIGN KEY (idPaciente) REFERENCES Pacientes(id),
    FOREIGN KEY (idMedico) REFERENCES Medicos(id),
	FOREIGN KEY (medicamento_Uno) REFERENCES Medicamentos(id),
	FOREIGN KEY (medicamento_Dos) REFERENCES Medicamentos(id),
	FOREIGN KEY (medicamento_Tres) REFERENCES Medicamentos(id),
	FOREIGN KEY (medicamento_Cuatro) REFERENCES Medicamentos(id)
);

---- CARGAR COMBOBOX ----
CREATE PROCEDURE CargarMedicos
AS
SELECT nombre from Medicos;

CREATE PROCEDURE CargarPacientes
AS
SELECT nombre from Pacientes;

CREATE PROCEDURE CargarMedicamentos
AS
SELECT nombre from Medicamentos;

--- INSERCIÓN DE USUARIO ---
INSERT INTO Administrador VALUES ('user', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918');