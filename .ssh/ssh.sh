#!/bin/sh

BASE=`dirname "$0"`

exec ssh -i "$BASE/id_rsa" "$@"
