terraform {
    required_providers {
        azurerm = {
            source  = "hashicorp/azurerm"
            version = "~> 2.46.0"
        }    
    }    
}

provider "azurerm" {
    features {}
}
variable "services" {
  description = "List of web apps"
  type        = map
  default     = {
    frontend = {
      name="sam-frontend"
    },
    serviceone = {
      name="sam-letters"
    },
    servicetwo = {
      name="sam-numbers"
    },
    servicethree = {
      name="sam-merge"
    },
  }
}

resource "azurerm_resource_group" "rg" {
    name     = "samuel.nwangwu_rg"
    location = "uksouth"
}
resource "azurerm_app_service_plan" "app-service-plan" {
  name = "letters-project"
  resource_group_name = azurerm_resource_group.rg.name
  location = "uksouth"
  kind = "Linux"
  reserved = true
  sku {
    tier = "Basic"
    size = "B1"
  }
}
resource "azurerm_app_service" "webapp" {
  
    for_each = var.services
    name = each.value.name
    resource_group_name = azurerm_resource_group.rg.name
    location = azurerm_resource_group.rg.location
    app_service_plan_id = azurerm_app_service_plan.app-service-plan.id
}