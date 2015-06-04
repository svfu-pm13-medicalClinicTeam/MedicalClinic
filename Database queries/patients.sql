-- Table: patients

-- DROP TABLE patients;

CREATE TABLE patients
(
  id integer NOT NULL,
  first_name character varying(40),
  middle_name character varying(40),
  last_name character varying(40),
  gender character(1),
  date_of_birth date,
  passport character varying(21),
  policy character varying(16),
  telephone_number character varying(12),
  CONSTRAINT patients_pkey PRIMARY KEY (id),
  CONSTRAINT patients_unique_policy UNIQUE (policy)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE patients
  OWNER TO postgres;
