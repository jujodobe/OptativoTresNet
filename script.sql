-- public.ciudad definition -- Drop table -- DROP TABLE public.ciudad; CREATE TABLE public.ciudad (
	nombre_corto varchar(5) NULL,
	estado varchar(10) NOT NULL,
	idciudad int4 NOT NULL,
	descripcion varchar(30) NOT NULL,
	CONSTRAINT ciudad_pk null
);
