-- Table: specializations

-- DROP TABLE specializations;

CREATE TABLE specializations
(
  id integer NOT NULL,
  title character varying(40),
  CONSTRAINT specializations_pkey PRIMARY KEY (id),
  CONSTRAINT specializations_unique_title UNIQUE (title)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE specializations
  OWNER TO postgres;
