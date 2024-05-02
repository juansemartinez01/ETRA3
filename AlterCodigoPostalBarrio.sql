

-- Agregar una columna de texto llamada 'barrio'
ALTER TABLE direccion
ADD barrio VARCHAR(MAX) NULL; -- VARCHAR(MAX) permite muchos caracteres y puede ser NULL

-- Agregar una columna entera llamada 'codPos'
ALTER TABLE direccion
ADD codPos INT NULL; -- INT para números enteros y puede ser NULL