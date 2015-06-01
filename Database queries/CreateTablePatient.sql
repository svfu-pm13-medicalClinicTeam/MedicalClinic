CREATE TABLE patient
(
  id serial NOT NULL,
  first_name character varying(40),
  middle_name character varying(40),
  last_name character varying(40),
  gender character(1),
  date_of_birth date,
  passport character varying(21),
  inn character varying(12),
  polis character varying(16) NOT NULL,
  snils character varying(11),
  telephone_number character varying(12),
  CONSTRAINT patient_pkey PRIMARY KEY (id),
  CONSTRAINT patient_inn_key UNIQUE (inn),
  CONSTRAINT patient_passport_key UNIQUE (passport),
  CONSTRAINT patient_polis_key UNIQUE (polis),
  CONSTRAINT patient_snils UNIQUE (snils)
)