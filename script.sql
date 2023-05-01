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

-- Table: public.city

-- DROP TABLE IF EXISTS public.city;

CREATE TABLE IF NOT EXISTS public.city
(
    id bigint NOT NULL DEFAULT nextval('"City_id_seq"'::regclass),
    state character varying COLLATE pg_catalog."default",
    city character varying COLLATE pg_catalog."default",
    CONSTRAINT "City_pkey" PRIMARY KEY (id)
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.city
    OWNER to postgres;
    
    -- SEQUENCE: public.subject_id_seq

-- DROP SEQUENCE IF EXISTS public.subject_id_seq;

CREATE SEQUENCE IF NOT EXISTS public.subject_id_seq
    INCREMENT 1
    START 1
    MINVALUE 1
    MAXVALUE 9223372036854775807
    CACHE 1
    OWNED BY subject.id;

ALTER SEQUENCE public.subject_id_seq
    OWNER TO postgres;
    
    -- SEQUENCE: public.City_id_seq

-- DROP SEQUENCE IF EXISTS public."City_id_seq";

CREATE SEQUENCE IF NOT EXISTS public."City_id_seq"
    INCREMENT 1
    START 1
    MINVALUE 1
    MAXVALUE 9223372036854775807
    CACHE 1
    OWNED BY city.id;

ALTER SEQUENCE public."City_id_seq"
    OWNER TO postgres;
