variable "aws_region" {
    type    = string
    default = "us-east-2"
}
variable "aws_profile" {
    type    = string
    default = "default"
}

variable "application" {
    type    = string
    default = "<MY_APP_NAME>"
}

variable "vpc" {
    type    = string
    default = "<MY_VPC>"
}

variable "subnets" {
    type    = list
    default = ["<MY_SUBNET>"]
}

variable "keypair"  {
    type    = string
    default = "<MY_KEY_PAIR>"
}