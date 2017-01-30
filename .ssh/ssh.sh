#!/bin/sh

exec ssh -i `basename $0`/id_rsa "$@"
