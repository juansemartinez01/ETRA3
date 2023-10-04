-- Crear la tabla EstadoCivil
CREATE TABLE EstadoCivil (
    id INT PRIMARY KEY,
    nombre VARCHAR(255) -- Cambia el tamaño máximo según tus necesidades
);

-- Agregar la columna "estadoCivil_id" como clave foránea a la tabla Colaborador
ALTER TABLE Colaborador
ADD estadoCivil_id INT;

-- Definir la restricción de clave foránea para la columna "estadoCivil_id"
ALTER TABLE Colaborador
ADD CONSTRAINT FK_Colaborador_estadoCivil
FOREIGN KEY (estadoCivil_id)
REFERENCES EstadoCivil(id);

-- Agregar la columna "escolaridad_id" como clave foránea a la tabla Colaborador
ALTER TABLE Colaborador
ADD escolaridad_id INT;

-- Definir la restricción de clave foránea para la columna "escolaridad_id"
ALTER TABLE Colaborador
ADD CONSTRAINT FK_Colaborador_escolaridad
FOREIGN KEY (escolaridad_id)
REFERENCES Escolaridad(id);


INSERT INTO EstadoCivil VALUES (1,'Casado');
INSERT INTO EstadoCivil VALUES (2,'Soltero');
INSERT INTO EstadoCivil VALUES (3,'Concubinato');








