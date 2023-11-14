USE `Risko`;
/*--------------------SEGURIDAD---------------*/
-- -----MODULOS

INSERT INTO `tbl_modulos` VALUES
('1000', 'SEGURIDAD', 'Seguridad', 1),
('2000', 'AUDITORIA', 'auditoria', 1)
;

-- -----APLICACIONES
INSERT INTO `tbl_aplicaciones` VALUES
('1', 'Menu', 'Ingreso Login', '1'),
('999', 'Cerrar Sesion', 'Cerrar Sesion', '1'),
('1000', 'MDI SEGURIDAD', 'PARA SEGURIDAD', '1'),
('1001', 'Mant. Usuario', 'PARA SEGURIDAD', '1'),
('1002', 'Mant. Aplicación', 'PARA SEGURIDAD', '1'),
('1003', 'Mant. Modulo', 'PARA SEGURIDAD', '1'),
('1004', 'Mant. Perfil', 'PARA SEGURIDAD', '1'),
('1101', 'Asign. Modulo Aplicacion', 'PARA SEGURIDAD', '1'),
('1102', 'Asign. Aplicacion Perfil', 'PARA SEGURIDAD', '1'),
('1103', 'Asign. Perfil Usuario', 'PARA SEGURIDAD', '1'),
('1201', 'Pcs. Cambio Contraseña', 'PARA SEGURIDAD', '1'),
('1301', 'Pcs. BITACORA', 'PARA SEGURIDAD', '1'),
('2000', 'MDI VENTAS', 'PARA AUDITORIA', '1'),
('2001', 'Mant. Usuarios', 'PARA AUDITORIA', '1'),
('2002', 'Mant. Empresas', 'PARA AUDITORIA', '1'),
('2003', 'Mant. Estandares', 'PARA AUDITORIA', '1'),
('2004', 'Mant. Medidas', 'PARA AUDITORIA', '1'),
('2005', 'Mant. Unidades', 'PARA AUDITORIA', '1'),
('2006', 'Mant. Prioridades', 'PARA AUDITORIA', '1'),
('2101', 'PcsH. Proyectos', 'PARA AUDITORIA', '1'),
('2102', 'PcsH. Actividades', 'PARA AUDITORIA', '1'),
('2103', 'PcsH. Recursos', 'PARA AUDITORIA', '1'),
('2104', 'PcsH. Grupos', 'PARA AUDITORIA', '1'),
('2105', 'PcsH. Asignacion Grupos', 'PARA AUDITORIA', '1'),
('2106', 'PcsH. Informes', 'PARA AUDITORIA', '1'),
('2107', 'PcsH. Rubrica', 'PARA AUDITORIA', '1'),
('3001', 'Proyectos', 'PARA AUDITORIA', '1'),
('3002', 'Asignacion grupos', 'PARA AUDITORIA', '1'),
('3101', 'Estandares', 'PARA AUDITORIA', '1')
;

-- -----USUARIOS
INSERT INTO `tbl_usuarios` VALUES
('1', 'admin', 'admin', 'admin', 'HO0aGo4nM94=', 'esduardo@gmail.com', '1', 'COLOR FAVORITO', 'X9yc1/l1b2A='),
('2', 'seguridad', 'seguridad', 'seguridad', 'X9yc1/l1b2A=', 'seguridad@gmail.com', '1', 'COLOR FAVORITO', 'X9yc1/l1b2A='),
('3', 'auditoria', 'auditoria', 'auditoria', 'X9yc1/l1b2A=', 'auditoria@gmail.com', '1', 'COLOR FAVORITO', 'X9yc1/l1b2A=')
;

-- -----PERFILES
INSERT INTO `tbl_perfiles` VALUES
('1', 'ADMINISTRADOR', 'contiene todos los permisos del programa', 1),
('2', 'SEGURIDAD', 'contiene todos los permisos de seguridad', 1),
('3', 'AUDITORIA', 'contiene todos los permisos de auditoria', 1)
;

-- -----ASIGNACIÓNES MODULO A APLICACION
INSERT INTO `tbl_asignacionmoduloaplicacion` VALUES
('1000', '1000'),
('1000', '1001'),
('1000', '1002'),
('1000', '1003'),
('1000', '1004'),
('1000', '1102'),
('1000', '1103'),
('1000', '1201'),
('1000', '1301'),
('2000', '2000'),
('2000', '2001'),
('2000', '2002'),
('2000', '2003'),
('2000', '2004'),
('2000', '2005'),
('2000', '2006'),
('2000', '2101'),
('2000', '2102'),
('2000', '2103'),
('2000', '2104'),
('2000', '2105'),
('2000', '2106'),
('2000', '2107'),
('2000', '3001'),
('2000', '3002'),
('2000', '3101')
;

-- -----PERMISOS DE APLICACIONES A PERFILES
INSERT INTO `tbl_permisosAplicacionPerfil` VALUES
('1', '1000', '1', '1', '1', '1', '1'),
('1', '1001', '1', '1', '1', '1', '1'),
('1', '1002', '1', '1', '1', '1', '1'),
('1', '1003', '1', '1', '1', '1', '1'),
('1', '1004', '1', '1', '1', '1', '1'),
('1', '1101', '1', '1', '1', '1', '1'),
('1', '1102', '1', '1', '1', '1', '1'),
('1', '1103', '1', '1', '1', '1', '1'),
('1', '1201', '1', '1', '1', '1', '1'),
('1', '1301', '1', '1', '1', '1', '1'),
('1', '2000', '1', '1', '1', '1', '1'),
('1', '2001', '1', '1', '1', '1', '1'),
('1', '2002', '1', '1', '1', '1', '1'),
('1', '2003', '1', '1', '1', '1', '1'),
('1', '2004', '1', '1', '1', '1', '1'),
('1', '2005', '1', '1', '1', '1', '1'),
('1', '2006', '1', '1', '1', '1', '1'),
('1', '2101', '1', '1', '1', '1', '1'),
('1', '2102', '1', '1', '1', '1', '1'),
('1', '2103', '1', '1', '1', '1', '1'),
('1', '2104', '1', '1', '1', '1', '1'),
('1', '2105', '1', '1', '1', '1', '1'),
('1', '2106', '1', '1', '1', '1', '1'),
('1', '2107', '1', '1', '1', '1', '1'),
('1', '3001', '1', '1', '1', '1', '1'),
('1', '3002', '1', '1', '1', '1', '1'),
('1', '3101', '1', '1', '1', '1', '1'),
('2', '1000', '1', '1', '1', '1', '1'),
('2', '1001', '1', '1', '1', '1', '1'),
('2', '1002', '1', '1', '1', '1', '1'),
('2', '1003', '1', '1', '1', '1', '1'),
('2', '1004', '1', '1', '1', '1', '1'),
('2', '1101', '1', '1', '1', '1', '1'),
('2', '1102', '1', '1', '1', '1', '1'),
('2', '1103', '1', '1', '1', '1', '1'),
('2', '1201', '1', '1', '1', '1', '1'),
('2', '1301', '1', '1', '1', '1', '1'),
('3', '2000', '1', '1', '1', '1', '1'),
('3', '2001', '1', '1', '1', '1', '1'),
('3', '2002', '1', '1', '1', '1', '1'),
('3', '2003', '1', '1', '1', '1', '1'),
('3', '2004', '1', '1', '1', '1', '1'),
('3', '2005', '1', '1', '1', '1', '1'),
('3', '2006', '1', '1', '1', '1', '1'),
('3', '2101', '1', '1', '1', '1', '1'),
('3', '2102', '1', '1', '1', '1', '1'),
('3', '2103', '1', '1', '1', '1', '1'),
('3', '2104', '1', '1', '1', '1', '1'),
('3', '2105', '1', '1', '1', '1', '1'),
('3', '2106', '1', '1', '1', '1', '1'),
('3', '2107', '1', '1', '1', '1', '1')
;

-- -----ASIGNACIÓN DE PERFIL A USUARIO
INSERT INTO `tbl_asignacionesPerfilsUsuario` VALUES
('1', '1'),
('2', '2'),
('3', '3')
; 

INSERT INTO tbl_regreporteria(idregistro,ruta,nombre_archivo,aplicacion,estado) VALUES(1,'RptPrioridades.rpt','RptPrioridades','2006','visible');
INSERT INTO tbl_regreporteria(idregistro,ruta,nombre_archivo,aplicacion,estado) VALUES(2,'ReporteEstandares.rpt','estandares','2003','visible');
INSERT INTO tbl_regreporteria(idregistro,ruta,nombre_archivo,aplicacion,estado) VALUES(3,'ReporteMedidas.rpt','Medidas','2004','visible');
