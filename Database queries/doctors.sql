-- Table: doctors

-- DROP TABLE doctors;

CREATE TABLE doctors
(
  id integer NOT NULL,
  first_name character varying(40),
  middle_name character varying(40),
  last_name character varying(40),
  specialization_id integer,
  category character(1),
  gender character(1),
  date_of_birth date,
  passport character varying(21),
  inn character varying(12),
  snils character varying(11),
  telephone_number character varying(12),
  CONSTRAINT doctors_pkey PRIMARY KEY (id),
  CONSTRAINT doctors_fkey_specialization FOREIGN KEY (specialization_id)
      REFERENCES specializations (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION,
  CONSTRAINT doctors_unique_inn UNIQUE (inn),
  CONSTRAINT doctors_unique_snils UNIQUE (snils),
  CONSTRAINT doctors_unque_passprot UNIQUE (passport)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE doctors
  OWNER TO postgres;
