-- Table: public.subject

-- DROP TABLE IF EXISTS public.subject;

CREATE TABLE IF NOT EXISTS public.subject
(
    id bigint NOT NULL DEFAULT nextval('subject_id_seq'::regclass),
    name character varying COLLATE pg_catalog."default" NOT NULL,
    lastname character varying COLLATE pg_catalog."default" NOT NULL,
    city character varying COLLATE pg_catalog."default" NOT NULL,
    birthday date NOT NULL,
    country character varying COLLATE pg_catalog."default" NOT NULL,
    ci character varying COLLATE pg_catalog."default" NOT NULL,
    id_city bigint NOT NULL,
    email character varying COLLATE pg_catalog."default",
    telephone character varying COLLATE pg_catalog."default",
    CONSTRAINT subject_pkey PRIMARY KEY (id),
    CONSTRAINT fk_city_id FOREIGN KEY (id_city)
        REFERENCES public.city (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
        NOT VALID
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.subject
    OWNER to postgres;
