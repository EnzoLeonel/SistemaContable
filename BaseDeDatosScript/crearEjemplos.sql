insert  into `asiento`(`id_asiento`,`numero_asiento`,`fecha_asiento`,`descr_asiento`) values (3,3,'2021-11-02','Prestamo concedido desde banco Macro');
insert  into `movimiento`(`id_movimiento`,`asiento_id`,`cuenta_id`,`valor`,`debeohaber`) values (24,3,1,5000000,1),(25,3,36,5000000,0);

insert  into `asiento`(`id_asiento`,`numero_asiento`,`fecha_asiento`,`descr_asiento`) values (4,4,'2021-11-24','Prestamo concedido desde banco BBVA');
insert  into `movimiento`(`id_movimiento`,`asiento_id`,`cuenta_id`,`valor`,`debeohaber`) values (10,4,1,5000000,1),(11,4,36,5000000,0);

insert  into `asiento`(`id_asiento`,`numero_asiento`,`fecha_asiento`,`descr_asiento`) values (5,5,'2021-11-24','Compra de mercancias a crédito');
insert  into `movimiento`(`id_movimiento`,`asiento_id`,`cuenta_id`,`valor`,`debeohaber`) values (12,5,5,700000,1),(13,5,11,700000,0);

insert  into `asiento`(`id_asiento`,`numero_asiento`,`fecha_asiento`,`descr_asiento`) values (6,6,'2021-11-24','Pago a proveedor x');
insert  into `movimiento`(`id_movimiento`,`asiento_id`,`cuenta_id`,`valor`,`debeohaber`) values (14,6,11,700000,1),(15,6,2,700000,0);

insert  into `asiento`(`id_asiento`,`numero_asiento`,`fecha_asiento`,`descr_asiento`) values (7,7,'2021-11-24','Compra de terreno');
insert  into `movimiento`(`id_movimiento`,`asiento_id`,`cuenta_id`,`valor`,`debeohaber`) values (16,7,7,1000000,1),(17,7,12,1000000,0);

insert  into `asiento`(`id_asiento`,`numero_asiento`,`fecha_asiento`,`descr_asiento`) values (8,8,'2021-11-24','Compra de 3 escritorios');
insert  into `movimiento`(`id_movimiento`,`asiento_id`,`cuenta_id`,`valor`,`debeohaber`) values (18,8,9,150000,1),(19,8,11,75000,0),(20,7,12,75000,0);

insert  into `asiento`(`id_asiento`,`numero_asiento`,`fecha_asiento`,`descr_asiento`) values (9,9,'2023-11-24','Compra de camioneta');
insert  into `movimiento`(`id_movimiento`,`asiento_id`,`cuenta_id`,`valor`,`debeohaber`) values (21,9,6,2000000,1),(22,9,2,1500000,0),(23,8,12,500000,0);