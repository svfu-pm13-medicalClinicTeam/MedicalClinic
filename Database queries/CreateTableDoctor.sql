CREATE TABLE doctor
(
  id serial NOT NULL,
  first_name character varying(40),
  middle_name character varying(40),
  last_name character varying(40),
  specialization character varying(40),
  category character varying(40),
  gender character(1),
  date_of_birth date,
  passport character varying(21),
  inn character varying(12),
  telephone_number character varying(12),

  CONSTRAINT doctor_pkey PRIMARY KEY (id),
  CONSTRAINT doctor_inn_key UNIQUE (inn),
  CONSTRAINT doctor_passport_key UNIQUE (passport)
)