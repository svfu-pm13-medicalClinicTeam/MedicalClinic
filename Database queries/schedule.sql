-- Table: schedule

-- DROP TABLE schedule;

CREATE TABLE schedule
(
  id integer NOT NULL,
  doctor_id integer,
  time_of_receipt timestamp without time zone,
  cabinet_id integer,
  patient_id integer,
  busy boolean,
  CONSTRAINT schedule_pkey PRIMARY KEY (id),
  CONSTRAINT schedule_fkey_cabinets FOREIGN KEY (cabinet_id)
      REFERENCES cabinets (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION,
  CONSTRAINT schedule_fkey_doctors FOREIGN KEY (doctor_id)
      REFERENCES doctors (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION,
  CONSTRAINT schedule_fkey_patients FOREIGN KEY (patient_id)
      REFERENCES patients (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION
)
WITH (
  OIDS=FALSE
);
ALTER TABLE schedule
  OWNER TO postgres;
