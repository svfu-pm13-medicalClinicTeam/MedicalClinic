CREATE TABLE schedule
(
  id serial NOT NULL,
  doctor_id integer NOT NULL,
  date_of_receipt date NOT NULL,
  time_of_receipt time without time zone NOT NULL,
  patient_polis character varying(16) NOT NULL,
  busy boolean,
  CONSTRAINT schedule_pkey PRIMARY KEY (id),
  CONSTRAINT schedule_fkey_patient FOREIGN KEY (patient_polis)
      REFERENCES patient (polis) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION,
  CONSTRAINT scheduley_fkey_doctor FOREIGN KEY (doctor_id)
      REFERENCES doctor (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION
)
