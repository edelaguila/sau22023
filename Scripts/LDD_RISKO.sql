

CREATE DATABASE IF NOT EXISTS `Risko`;
USE `Risko`;

/*--------------Tablas para componentes*/
/*------Consulta Inteligente------------------*/
DROP TABLE IF EXISTS tbl_consultainteligente;
CREATE TABLE IF NOT EXISTS tbl_consultainteligente (
	nombre_consulta varchar(50) not null,
    tabla_consulta varchar(50) not null,
    campos_consultas varchar(50) not null,
    alias_consultas varchar(50) not null,
    cadena_consultas varchar(80) not null,
    PkId INT NOT NULL,
    PRIMARY KEY (PkId)
)ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

DROP TABLE IF EXISTS tbl_consultainteligente1; 
CREATE TABLE IF NOT EXISTS tbl_consultainteligente1 (
 operador_consulta varchar(50) not null,
    campos_consulta varchar(50) not null,
    valor_consultas varchar(50) not null,
    PkId INT NOT NULL,   
    metodo varchar(50) not null,
    PRIMARY KEY (PkId)
)ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

DROP TABLE IF EXISTS tbl_consultainteligente2;
CREATE TABLE IF NOT EXISTS tbl_consultainteligente2 (
    PkId INT NOT NULL,
    ordenar_consulta varchar(50) not null,
    campo_consulta varchar(50) not null,    
    metodo varchar(50) not null,
    PRIMARY KEY (PkId)
)ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

/*---------Reporteria----------*/

CREATE TABLE IF NOT EXISTS tbl_regreporteria (
  idregistro int NOT NULL AUTO_INCREMENT,
  ruta varchar(500) NOT NULL,
  nombre_archivo varchar(45) NOT NULL,
  aplicacion varchar(45) NOT NULL,
  estado varchar(45) NOT NULL,
  PRIMARY KEY (idregistro)
) ENGINE=InnoDB;

/*-----------Seguridad-----------*/

DROP TABLE IF EXISTS tbl_modulos;
CREATE TABLE IF NOT EXISTS tbl_modulos (
	pk_id_modulos INT NOT NULL,
    nombre_modulo VARCHAR(50) NOT NULL,
    descripcion_modulo VARCHAR(150) NOT NULL,
    estado_modulo TINYINT DEFAULT 0,
    primary key (pk_id_modulos)
);

DROP TABLE IF EXISTS tbl_aplicaciones;
CREATE TABLE IF NOT EXISTS tbl_aplicaciones (
	pk_id_aplicacion INT NOT NULL,
    nombre_aplicacion VARCHAR(50) NOT NULL,
    descripcion_aplicacion VARCHAR(150) NOT NULL,
    estado_aplicacion TINYINT DEFAULT 0,
    primary key (pk_id_aplicacion)
);

DROP TABLE IF EXISTS tbl_AsignacionModuloAplicacion;
CREATE TABLE IF NOT EXISTS tbl_AsignacionModuloAplicacion (
  fk_id_modulos INT NOT NULL,
  fk_id_aplicacion INT NOT NULL, 
  PRIMARY KEY (fk_id_modulos,fk_id_aplicacion ),
  FOREIGN KEY (fk_id_modulos) REFERENCES tbl_modulos (pk_id_modulos),
  FOREIGN KEY (fk_id_aplicacion) REFERENCES tbl_aplicaciones (pk_id_aplicacion)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

DROP TABLE IF EXISTS tbl_usuarios;
CREATE TABLE IF NOT EXISTS tbl_usuarios (
  pk_id_usuario INT AUTO_INCREMENT NOT NULL,
  nombre_usuario VARCHAR(50) NOT NULL,
  apellido_usuario VARCHAR(50) NOT NULL,
  username_usuario VARCHAR(20) NOT NULL,
  password_usuario VARCHAR(100) NOT NULL,
  email_usuario VARCHAR(50) NOT NULL,
  estado_usuario TINYINT DEFAULT 0 NOT NULL,
  pregunta varchar(50) not null,
  respuesta varchar(50) not null,
  PRIMARY KEY (pk_id_usuario)
);

DROP TABLE IF EXISTS tbl_perfiles;
CREATE TABLE IF NOT EXISTS tbl_perfiles (
	pk_id_perfil INT AUTO_INCREMENT NOT NULL,
    nombre_perfil VARCHAR(50) NOT NULL,
    descripcion_perfil VARCHAR(150) NOT NULL,
    estado_perfil TINYINT DEFAULT 0,
    primary key (pk_id_perfil)
);

DROP TABLE IF EXISTS tbl_permisosAplicacionesUsuario;
CREATE TABLE IF NOT EXISTS tbl_permisosAplicacionesUsuario (
  fk_id_aplicacion INT NOT NULL, 
  fk_id_usuario INT NOT NULL, 
  guardar_permiso BOOLEAN DEFAULT FALSE,
  modificar_permiso BOOLEAN DEFAULT FALSE,
  eliminar_permiso BOOLEAN DEFAULT FALSE,
  buscar_permiso BOOLEAN DEFAULT FALSE,
  imprimir_permiso BOOLEAN DEFAULT FALSE,
  PRIMARY KEY (fk_id_aplicacion,fk_id_usuario),
  FOREIGN KEY (fk_id_aplicacion) REFERENCES tbl_aplicaciones (pk_id_aplicacion),
  FOREIGN KEY (fk_id_usuario) REFERENCES tbl_usuarios (pk_id_usuario)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

DROP TABLE IF EXISTS tbl_permisosAplicacionPerfil;
CREATE TABLE IF NOT EXISTS tbl_permisosAplicacionPerfil (
  fk_id_perfil INT NOT NULL, 
  fk_id_aplicacion INT NOT NULL, 
  guardar_permiso BOOLEAN DEFAULT FALSE,
  modificar_permiso BOOLEAN DEFAULT FALSE,
  eliminar_permiso BOOLEAN DEFAULT FALSE,
  buscar_permiso BOOLEAN DEFAULT FALSE,
  imprimir_permiso BOOLEAN DEFAULT FALSE,
  PRIMARY KEY (fk_id_perfil,fk_id_aplicacion),
  FOREIGN KEY (fk_id_aplicacion) REFERENCES tbl_aplicaciones (pk_id_aplicacion),
  FOREIGN KEY (fk_id_perfil) REFERENCES tbl_perfiles (pk_id_perfil)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

DROP TABLE IF EXISTS tbl_asignacionesPerfilsUsuario;
CREATE TABLE IF NOT EXISTS tbl_asignacionesPerfilsUsuario (
  fk_id_usuario INT NOT NULL, 
  fk_id_perfil INT NOT NULL,
  PRIMARY KEY (fk_id_usuario,fk_id_perfil ),
  FOREIGN KEY (fk_id_usuario) REFERENCES tbl_usuarios (pk_id_usuario),
  FOREIGN KEY (fk_id_perfil) REFERENCES tbl_perfiles (pk_id_perfil)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

DROP TABLE IF EXISTS tbl_bitacoraDeEventos;
CREATE TABLE IF NOT EXISTS tbl_bitacoraDeEventos (
  pk_id_bitacora INT AUTO_INCREMENT NOT NULL,
  fk_id_usuario INT NOT NULL,
  fk_id_aplicacion INT NOT NULL,
  fecha_bitacora DATE NOT NULL,
  hora_bitacora TIME NOT NULL,
  host_bitacora VARCHAR(45) NOT NULL,
  ip_bitacora VARCHAR(100) NOT NULL,
  accion_bitacora VARCHAR(50) NOT NULL,
  PRIMARY KEY (pk_id_bitacora),
  FOREIGN KEY (fk_id_usuario) REFERENCES tbl_usuarios (pk_id_usuario),
  FOREIGN KEY (fk_id_aplicacion) REFERENCES tbl_aplicaciones (pk_id_aplicacion)
)ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;


-- vistas Seguridad------------------------------------------------------------------------
CREATE 
VIEW risko.vista_aplicacion_perfil AS 
    SELECT 
        b.fk_id_perfil AS ID,
        a.nombre_perfil AS Perfil,
        b.fk_id_aplicacion AS Aplicacion,
        b.guardar_permiso AS Insertar,
        b.modificar_permiso AS Modificar,
        b.eliminar_permiso AS Eliminar,
        b.buscar_permiso AS Buscar,
        b.imprimir_permiso AS Reporte
    FROM
        (risko.tbl_permisosaplicacionperfil b
        JOIN risko.tbl_perfiles a ON ((a.pk_id_perfil = b.fk_id_perfil)));
        
CREATE 
VIEW risko.vista_aplicacionusuario AS
    SELECT 
        b.fk_id_aplicacion AS Aplicacion,
        b.fk_id_usuario AS ID,
        a.nombre_usuario AS Usuario,
        b.guardar_permiso AS Insertar,
        b.modificar_permiso AS Editar,
        b.eliminar_permiso AS Eliminar,
        b.buscar_permiso AS Buscar,
        b.imprimir_permiso AS Reporte
    FROM
        (risko.tbl_permisosaplicacionesusuario b
        JOIN risko.tbl_usuarios a ON ((a.pk_id_usuario = b.fk_id_usuario)));
        
CREATE 
VIEW risko.vista_modulo_aplicacion AS
    SELECT 
        b.fk_id_modulos AS ID,
        a.nombre_modulo AS Modulo,
        b.fk_id_aplicacion AS Aplicacion,
        c.nombre_aplicacion AS Nombre,
        c.descripcion_aplicacion AS Descripcion
    FROM
        ((risko.tbl_asignacionmoduloaplicacion b
        JOIN risko.tbl_modulos a ON ((a.pk_id_modulos = b.fk_id_modulos)))
        JOIN risko.tbl_aplicaciones c ON ((c.pk_id_aplicacion = b.fk_id_aplicacion)));
        
CREATE 
VIEW risko.vista_perfil_usuario AS
    SELECT 
        b.fk_id_usuario AS ID,
        a.nombre_usuario AS Usuario,
        a.username_usuario AS nickName,
        b.fk_id_perfil AS perfil,
        c.nombre_perfil AS Nombre
    FROM
        ((risko.tbl_asignacionesperfilsusuario b
        JOIN risko.tbl_usuarios a ON ((a.pk_id_usuario = b.fk_id_usuario)))
        JOIN risko.tbl_perfiles c ON ((c.pk_id_perfil = b.fk_id_perfil)));

/*-------------Tablas para Auditoria */
CREATE TABLE IF NOT EXISTS `tbl_medidas`(
    pk_id_medida INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nombre_medida VARCHAR(255) NOT NULL,
    descripcion_medida VARCHAR(100) NOT NULL,
    estado_medida tinyint NOT NULL DEFAULT 1
);

CREATE TABLE IF NOT EXISTS `tbl_unidades`(
    pk_id_unidad INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    fk_id_medida INT NOT NULL,
    nombre_unidad VARCHAR(255) NOT NULL,
    descripcion_unidad VARCHAR(100) NOT NULL,
    estado_unidad tinyint NOT NULL DEFAULT 1,
    FOREIGN KEY (fk_id_medida) REFERENCES tbl_medidas(pk_id_medida)
);

CREATE TABLE IF NOT EXISTS `tbl_estandares`(
    pk_id_estandar INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nombre_estandar VARCHAR(255) NOT NULL,
    norma_estandar VARCHAR(255) NOT NULL,
    estado_estandar tinyint NOT NULL DEFAULT 1
);

CREATE TABLE IF NOT EXISTS `tbl_prioridades` (
    pk_id_prioridad INT NOT NULL PRIMARY KEY,
    nombre_prioridad VARCHAR(50) NOT NULL,
    descripcion_prioridad VARCHAR(100) NOT NULL,
    estado_prioridad tinyint NOT NULL DEFAULT 1
);

CREATE TABLE IF NOT EXISTS `tbl_usuariosAuditoria` (
    pk_id_usurioAuditoria INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nombre_usuarioAuditoria VARCHAR(50) NOT NULL,
    apellido_usuarioAuditoria VARCHAR(50) NOT NULL,
    correo_usuarioAuditoria VARCHAR(50) NOT NULL,
    username_usuarioAuditoria VARCHAR(20) NOT NULL,
    password_usuarioAuditoria VARCHAR(255) NOT NULL,
    estado_usuarioAuditoria tinyint NOT NULL DEFAULT 1
);

CREATE TABLE IF NOT EXISTS `tbl_grupos`(
    pk_id_asignacion_grupo INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    fecha_creacion_grupo DATE NOT NULL,
    nombre_grupo VARCHAR(255) NOT NULL,
    descripcion_grupo VARCHAR(100) NOT NULL,
    fk_id_encargado INT NOT NULL,
    estado_grupo tinyint NOT NULL DEFAULT 1,
    FOREIGN KEY (fk_id_encargado) REFERENCES tbl_usuariosAuditoria(pk_id_usurioAuditoria)
);

CREATE TABLE IF NOT EXISTS `tbl_asignacion_grupo`(
    pk_id_asignacion_grupo INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    fk_id_grupo INT NOT NULL,
    fk_id_usuario INT NOT NULL,
    estado_asignacion_grupo tinyint NOT NULL DEFAULT 1,
    FOREIGN KEY (fk_id_grupo) REFERENCES tbl_grupos(pk_id_asignacion_grupo),
    FOREIGN KEY (fk_id_usuario) REFERENCES tbl_usuariosAuditoria(pk_id_usurioAuditoria)
);

CREATE TABLE IF NOT EXISTS `tbl_recursos`(
    pk_id_recurso INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    fk_id_encargado INT NOT NULL,
    nombre_recurso VARCHAR(255) NOT NULL,
    cantidad_recurso FLOAT NOT NULL,
    fk_id_unidad INT NOT NULL,
    costo_recurso FLOAT NOT NULL,
    estado_recurso tinyint NOT NULL DEFAULT 1,
    FOREIGN KEY (fk_id_encargado) REFERENCES tbl_usuariosAuditoria(pk_id_usurioAuditoria)
);

CREATE TABLE IF NOT EXISTS `tbl_empresas`(
    pk_id_empresa INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nombre_empresa VARCHAR(100) NOT NULL,
    direccion_empresa VARCHAR(100) NOT NULL,
    telefono_empresa VARCHAR(20) NOT NULL,
    correo_empresa VARCHAR(50) NOT NULL,
    fechaCreacion_empresa DATE NOT NULL,
    estado_empresa tinyint NOT NULL DEFAULT 1
);

CREATE TABLE IF NOT EXISTS `tbl_proyectos`(
    pk_id_proyecto INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    fk_id_empresa INT NOT NULL,
    fk_id_estandar INT NOT NULL,
    nombre_proyecto VARCHAR(255) NOT NULL,
    fechaInicio_proyecto DATE NOT NULL,
    fechaFinalizacion_proyecto DATE NOT NULL,
    estado_proyecto tinyint NOT NULL DEFAULT 1,
    FOREIGN KEY (fk_id_empresa) REFERENCES tbl_empresas(pk_id_empresa),
    FOREIGN KEY (fk_id_estandar) REFERENCES tbl_estandares(pk_id_estandar)
);

CREATE TABLE IF NOT EXISTS `tbl_actividades`(
    pk_id_actividad INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    fk_id_proyecto INT NOT NULL,
    fk_id_recurso INT NOT NULL,
    fk_id_prioridad INT NOT NULL,
    fk_id_grupo INT NOT NULL,
    nombre_actividad VARCHAR(255) NOT NULL,
    fechaInicio_actividad DATE NOT NULL,
    fechaFinalizacion_actividad DATE NOT NULL,
    totalTrabajado_actividad FLOAT NOT NULL,
    estado_actividad tinyint NOT NULL DEFAULT 1,
    FOREIGN KEY (fk_id_proyecto) REFERENCES tbl_proyectos(pk_id_proyecto),
    FOREIGN KEY (fk_id_recurso) REFERENCES tbl_recursos(pk_id_recurso),
    FOREIGN KEY (fk_id_prioridad) REFERENCES tbl_prioridades(pk_id_prioridad),
    FOREIGN KEY (fk_id_grupo) REFERENCES tbl_grupos(pk_id_asignacion_grupo)
);

CREATE TABLE IF NOT EXISTS `tbl_rubrica`(
    pk_id_rubrica INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    fk_id_aspecto INT NOT NULL,
    descripcion_rubrica VARCHAR(255) NOT NULL,
    estado_rubrica tinyint NOT NULL DEFAULT 1
    -- FOREIGN KEY (fk_id_aspecto) REFERENCES tbl_ (pk_id_aspecto)
);

CREATE TABLE IF NOT EXISTS `tbl_informes`(
    pk_id_informe INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    fk_id_actividad INT NOT NULL,
    fk_id_grupo INT NOT NULL,
    nombre_informe VARCHAR(255) NOT NULL,
    fechaInicio_informe DATE NOT NULL,
    fechaFinalizacion_informe DATE NOT NULL,
    descripcion_informe VARCHAR(255) NOT NULL,
    estado_informe tinyint NOT NULL DEFAULT 1,
    FOREIGN KEY (fk_id_actividad) REFERENCES tbl_actividades(pk_id_actividad),
    FOREIGN KEY (fk_id_grupo) REFERENCES tbl_grupos(pk_id_asignacion_grupo)
);