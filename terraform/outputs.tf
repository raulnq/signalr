output "applicatio_version_name" {
  value = aws_elastic_beanstalk_application_version.version.name
}
output "environment_name" {
  value = aws_elastic_beanstalk_environment.environment.name
}
output "environment_cname" {
  value = aws_elastic_beanstalk_environment.environment.cname
}
output "redis_configuration_endpoint" {
  value = aws_elasticache_replication_group.cluster.configuration_endpoint_address
}