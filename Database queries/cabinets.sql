-- Table: cabinets

-- DROP TABLE cabinets;

CREATE TABLE cabinets
(
  id integer NOT NULL,
  title character varying(40),
  CONSTRAINT cabinets_pkey PRIMARY KEY (id),
  CONSTRAINT cabinets_unique_title UNIQUE (title)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE cabinets
  OWNER TO postgres;
