#!/bin/sh

BASE=$PWD/`dirname "$0"`

exec ssh -i "$BASE/id_rsa" "$@"
