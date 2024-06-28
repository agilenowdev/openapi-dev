<?php
/**
 * Config
 *
 * PHP version 7.4
 *
 * @category Class
 * @package  OpenAPI\Client
 * @author   OpenAPI Generator team
 * @link     https://openapi-generator.tech
 */

/**
 * Accounts API documentation
 *
 * Agile.Now.AccessHub is a secure REST API designed to manage accounts, access groups, user groups, organizations, locations, applications, roles, and webhooks. This API provides a robust and scalable solution for managing user access and organizational structures in a multi-tenant environment.    **Key Features:**    1. **Accounts Management:**     - Manage user accounts with secure authentication and authorization.    2. **Access Groups:**     - Define and manage access groups for access control.     - Assign users to access groups based on roles and permissions.    3. **User Groups:**     - Create and manage user groups for better organization and collaboration.    4. **Organizations & Locations:**     - Manage multiple organizations and locations within a single platform.     - Attribute-based access control (ABAC) for settings.    5. **Applications:**     - Centralized management of applications within the platform.     - Assign and monitor application usage and access.    6. **Roles:**     - Define and manage roles for different access levels.     - Role-based access control to ensure appropriate permissions.    7. **Webhooks:**     - Integration with external services and applications.     - Configure and manage webhooks for real-time notifications and data syncing.    **Benefits:**    - **Enhanced Security:** Attribute-based and role-based access controls ensure data protection and authorized access.  - **Scalability:** Designed for growing organizations.  - **Efficiency:** Streamlined management of accounts, groups, and roles reduces overhead.  - **Flexibility:** Multi-tenant architecture allows easy customization.  - **Integration:** Webhook support facilitates seamless integration with external systems.    **Conclusion:**    Agile.Now.AccessHub is a powerful platform for managing your business data. It offers a centralized, secure, and scalable solution, enhancing operational efficiency, security, and flexibility in managing multi-tenant environments.
 *
 * The version of the OpenAPI document: 3.0.20
 * Generated by: https://openapi-generator.tech
 * Generator version: 7.6.0
 */

/**
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

namespace OpenAPI\Client\Model;

use \ArrayAccess;
use \OpenAPI\Client\ObjectSerializer;

/**
 * Config Class Doc Comment
 *
 * @category Class
 * @description The record of Config information.
 * @package  OpenAPI\Client
 * @author   OpenAPI Generator team
 * @link     https://openapi-generator.tech
 * @implements \ArrayAccess<string, mixed>
 */
class Config implements ModelInterface, ArrayAccess, \JsonSerializable
{
    public const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $openAPIModelName = 'Config';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $openAPITypes = [
        'id' => 'string',
        'webhook_entity_id' => '\OpenAPI\Client\Model\AbstractText',
        'has_create_access' => 'bool',
        'has_update_access' => 'bool',
        'has_delete_access' => 'bool',
        'is_active' => 'bool',
        'modified_by' => '\OpenAPI\Client\Model\AbstractLong',
        'modified_on' => '\DateTime',
        'created_by' => '\OpenAPI\Client\Model\AbstractLong',
        'created_on' => '\DateTime'
    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      * @phpstan-var array<string, string|null>
      * @psalm-var array<string, string|null>
      */
    protected static $openAPIFormats = [
        'id' => null,
        'webhook_entity_id' => null,
        'has_create_access' => null,
        'has_update_access' => null,
        'has_delete_access' => null,
        'is_active' => null,
        'modified_by' => null,
        'modified_on' => 'date-time',
        'created_by' => null,
        'created_on' => 'date-time'
    ];

    /**
      * Array of nullable properties. Used for (de)serialization
      *
      * @var boolean[]
      */
    protected static array $openAPINullables = [
        'id' => false,
        'webhook_entity_id' => false,
        'has_create_access' => false,
        'has_update_access' => false,
        'has_delete_access' => false,
        'is_active' => false,
        'modified_by' => false,
        'modified_on' => false,
        'created_by' => false,
        'created_on' => false
    ];

    /**
      * If a nullable field gets set to null, insert it here
      *
      * @var boolean[]
      */
    protected array $openAPINullablesSetToNull = [];

    /**
     * Array of property to type mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function openAPITypes()
    {
        return self::$openAPITypes;
    }

    /**
     * Array of property to format mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function openAPIFormats()
    {
        return self::$openAPIFormats;
    }

    /**
     * Array of nullable properties
     *
     * @return array
     */
    protected static function openAPINullables(): array
    {
        return self::$openAPINullables;
    }

    /**
     * Array of nullable field names deliberately set to null
     *
     * @return boolean[]
     */
    private function getOpenAPINullablesSetToNull(): array
    {
        return $this->openAPINullablesSetToNull;
    }

    /**
     * Setter - Array of nullable field names deliberately set to null
     *
     * @param boolean[] $openAPINullablesSetToNull
     */
    private function setOpenAPINullablesSetToNull(array $openAPINullablesSetToNull): void
    {
        $this->openAPINullablesSetToNull = $openAPINullablesSetToNull;
    }

    /**
     * Checks if a property is nullable
     *
     * @param string $property
     * @return bool
     */
    public static function isNullable(string $property): bool
    {
        return self::openAPINullables()[$property] ?? false;
    }

    /**
     * Checks if a nullable property is set to null.
     *
     * @param string $property
     * @return bool
     */
    public function isNullableSetToNull(string $property): bool
    {
        return in_array($property, $this->getOpenAPINullablesSetToNull(), true);
    }

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @var string[]
     */
    protected static $attributeMap = [
        'id' => 'Id',
        'webhook_entity_id' => 'WebhookEntityId',
        'has_create_access' => 'HasCreateAccess',
        'has_update_access' => 'HasUpdateAccess',
        'has_delete_access' => 'HasDeleteAccess',
        'is_active' => 'Is_Active',
        'modified_by' => 'ModifiedBy',
        'modified_on' => 'ModifiedOn',
        'created_by' => 'CreatedBy',
        'created_on' => 'CreatedOn'
    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'id' => 'setId',
        'webhook_entity_id' => 'setWebhookEntityId',
        'has_create_access' => 'setHasCreateAccess',
        'has_update_access' => 'setHasUpdateAccess',
        'has_delete_access' => 'setHasDeleteAccess',
        'is_active' => 'setIsActive',
        'modified_by' => 'setModifiedBy',
        'modified_on' => 'setModifiedOn',
        'created_by' => 'setCreatedBy',
        'created_on' => 'setCreatedOn'
    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'id' => 'getId',
        'webhook_entity_id' => 'getWebhookEntityId',
        'has_create_access' => 'getHasCreateAccess',
        'has_update_access' => 'getHasUpdateAccess',
        'has_delete_access' => 'getHasDeleteAccess',
        'is_active' => 'getIsActive',
        'modified_by' => 'getModifiedBy',
        'modified_on' => 'getModifiedOn',
        'created_by' => 'getCreatedBy',
        'created_on' => 'getCreatedOn'
    ];

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @return array
     */
    public static function attributeMap()
    {
        return self::$attributeMap;
    }

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @return array
     */
    public static function setters()
    {
        return self::$setters;
    }

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @return array
     */
    public static function getters()
    {
        return self::$getters;
    }

    /**
     * The original name of the model.
     *
     * @return string
     */
    public function getModelName()
    {
        return self::$openAPIModelName;
    }


    /**
     * Associative array for storing property values
     *
     * @var mixed[]
     */
    protected $container = [];

    /**
     * Constructor
     *
     * @param mixed[] $data Associated array of property values
     *                      initializing the model
     */
    public function __construct(array $data = null)
    {
        $this->setIfExists('id', $data ?? [], null);
        $this->setIfExists('webhook_entity_id', $data ?? [], null);
        $this->setIfExists('has_create_access', $data ?? [], false);
        $this->setIfExists('has_update_access', $data ?? [], false);
        $this->setIfExists('has_delete_access', $data ?? [], false);
        $this->setIfExists('is_active', $data ?? [], false);
        $this->setIfExists('modified_by', $data ?? [], null);
        $this->setIfExists('modified_on', $data ?? [], null);
        $this->setIfExists('created_by', $data ?? [], null);
        $this->setIfExists('created_on', $data ?? [], null);
    }

    /**
    * Sets $this->container[$variableName] to the given data or to the given default Value; if $variableName
    * is nullable and its value is set to null in the $fields array, then mark it as "set to null" in the
    * $this->openAPINullablesSetToNull array
    *
    * @param string $variableName
    * @param array  $fields
    * @param mixed  $defaultValue
    */
    private function setIfExists(string $variableName, array $fields, $defaultValue): void
    {
        if (self::isNullable($variableName) && array_key_exists($variableName, $fields) && is_null($fields[$variableName])) {
            $this->openAPINullablesSetToNull[] = $variableName;
        }

        $this->container[$variableName] = $fields[$variableName] ?? $defaultValue;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        if ($this->container['id'] === null) {
            $invalidProperties[] = "'id' can't be null";
        }
        if ($this->container['webhook_entity_id'] === null) {
            $invalidProperties[] = "'webhook_entity_id' can't be null";
        }
        return $invalidProperties;
    }

    /**
     * Validate all the properties in the model
     * return true if all passed
     *
     * @return bool True if all properties are valid
     */
    public function valid()
    {
        return count($this->listInvalidProperties()) === 0;
    }


    /**
     * Gets id
     *
     * @return string
     */
    public function getId()
    {
        return $this->container['id'];
    }

    /**
     * Sets id
     *
     * @param string $id The identifier of the config
     *
     * @return self
     */
    public function setId($id)
    {
        if (is_null($id)) {
            throw new \InvalidArgumentException('non-nullable id cannot be null');
        }
        $this->container['id'] = $id;

        return $this;
    }

    /**
     * Gets webhook_entity_id
     *
     * @return \OpenAPI\Client\Model\AbstractText
     */
    public function getWebhookEntityId()
    {
        return $this->container['webhook_entity_id'];
    }

    /**
     * Sets webhook_entity_id
     *
     * @param \OpenAPI\Client\Model\AbstractText $webhook_entity_id webhook_entity_id
     *
     * @return self
     */
    public function setWebhookEntityId($webhook_entity_id)
    {
        if (is_null($webhook_entity_id)) {
            throw new \InvalidArgumentException('non-nullable webhook_entity_id cannot be null');
        }
        $this->container['webhook_entity_id'] = $webhook_entity_id;

        return $this;
    }

    /**
     * Gets has_create_access
     *
     * @return bool|null
     */
    public function getHasCreateAccess()
    {
        return $this->container['has_create_access'];
    }

    /**
     * Sets has_create_access
     *
     * @param bool|null $has_create_access Service has create access to data
     *
     * @return self
     */
    public function setHasCreateAccess($has_create_access)
    {
        if (is_null($has_create_access)) {
            throw new \InvalidArgumentException('non-nullable has_create_access cannot be null');
        }
        $this->container['has_create_access'] = $has_create_access;

        return $this;
    }

    /**
     * Gets has_update_access
     *
     * @return bool|null
     */
    public function getHasUpdateAccess()
    {
        return $this->container['has_update_access'];
    }

    /**
     * Sets has_update_access
     *
     * @param bool|null $has_update_access Service has update access to data
     *
     * @return self
     */
    public function setHasUpdateAccess($has_update_access)
    {
        if (is_null($has_update_access)) {
            throw new \InvalidArgumentException('non-nullable has_update_access cannot be null');
        }
        $this->container['has_update_access'] = $has_update_access;

        return $this;
    }

    /**
     * Gets has_delete_access
     *
     * @return bool|null
     */
    public function getHasDeleteAccess()
    {
        return $this->container['has_delete_access'];
    }

    /**
     * Sets has_delete_access
     *
     * @param bool|null $has_delete_access Service has delete access to data
     *
     * @return self
     */
    public function setHasDeleteAccess($has_delete_access)
    {
        if (is_null($has_delete_access)) {
            throw new \InvalidArgumentException('non-nullable has_delete_access cannot be null');
        }
        $this->container['has_delete_access'] = $has_delete_access;

        return $this;
    }

    /**
     * Gets is_active
     *
     * @return bool|null
     */
    public function getIsActive()
    {
        return $this->container['is_active'];
    }

    /**
     * Sets is_active
     *
     * @param bool|null $is_active If true, the configuration is active
     *
     * @return self
     */
    public function setIsActive($is_active)
    {
        if (is_null($is_active)) {
            throw new \InvalidArgumentException('non-nullable is_active cannot be null');
        }
        $this->container['is_active'] = $is_active;

        return $this;
    }

    /**
     * Gets modified_by
     *
     * @return \OpenAPI\Client\Model\AbstractLong|null
     */
    public function getModifiedBy()
    {
        return $this->container['modified_by'];
    }

    /**
     * Sets modified_by
     *
     * @param \OpenAPI\Client\Model\AbstractLong|null $modified_by modified_by
     *
     * @return self
     */
    public function setModifiedBy($modified_by)
    {
        if (is_null($modified_by)) {
            throw new \InvalidArgumentException('non-nullable modified_by cannot be null');
        }
        $this->container['modified_by'] = $modified_by;

        return $this;
    }

    /**
     * Gets modified_on
     *
     * @return \DateTime|null
     */
    public function getModifiedOn()
    {
        return $this->container['modified_on'];
    }

    /**
     * Sets modified_on
     *
     * @param \DateTime|null $modified_on The date the record was updated.
     *
     * @return self
     */
    public function setModifiedOn($modified_on)
    {
        if (is_null($modified_on)) {
            throw new \InvalidArgumentException('non-nullable modified_on cannot be null');
        }
        $this->container['modified_on'] = $modified_on;

        return $this;
    }

    /**
     * Gets created_by
     *
     * @return \OpenAPI\Client\Model\AbstractLong|null
     */
    public function getCreatedBy()
    {
        return $this->container['created_by'];
    }

    /**
     * Sets created_by
     *
     * @param \OpenAPI\Client\Model\AbstractLong|null $created_by created_by
     *
     * @return self
     */
    public function setCreatedBy($created_by)
    {
        if (is_null($created_by)) {
            throw new \InvalidArgumentException('non-nullable created_by cannot be null');
        }
        $this->container['created_by'] = $created_by;

        return $this;
    }

    /**
     * Gets created_on
     *
     * @return \DateTime|null
     */
    public function getCreatedOn()
    {
        return $this->container['created_on'];
    }

    /**
     * Sets created_on
     *
     * @param \DateTime|null $created_on The date the record was created.
     *
     * @return self
     */
    public function setCreatedOn($created_on)
    {
        if (is_null($created_on)) {
            throw new \InvalidArgumentException('non-nullable created_on cannot be null');
        }
        $this->container['created_on'] = $created_on;

        return $this;
    }
    /**
     * Returns true if offset exists. False otherwise.
     *
     * @param integer $offset Offset
     *
     * @return boolean
     */
    public function offsetExists($offset): bool
    {
        return isset($this->container[$offset]);
    }

    /**
     * Gets offset.
     *
     * @param integer $offset Offset
     *
     * @return mixed|null
     */
    #[\ReturnTypeWillChange]
    public function offsetGet($offset)
    {
        return $this->container[$offset] ?? null;
    }

    /**
     * Sets value based on offset.
     *
     * @param int|null $offset Offset
     * @param mixed    $value  Value to be set
     *
     * @return void
     */
    public function offsetSet($offset, $value): void
    {
        if (is_null($offset)) {
            $this->container[] = $value;
        } else {
            $this->container[$offset] = $value;
        }
    }

    /**
     * Unsets offset.
     *
     * @param integer $offset Offset
     *
     * @return void
     */
    public function offsetUnset($offset): void
    {
        unset($this->container[$offset]);
    }

    /**
     * Serializes the object to a value that can be serialized natively by json_encode().
     * @link https://www.php.net/manual/en/jsonserializable.jsonserialize.php
     *
     * @return mixed Returns data which can be serialized by json_encode(), which is a value
     * of any type other than a resource.
     */
    #[\ReturnTypeWillChange]
    public function jsonSerialize()
    {
       return ObjectSerializer::sanitizeForSerialization($this);
    }

    /**
     * Gets the string presentation of the object
     *
     * @return string
     */
    public function __toString()
    {
        return json_encode(
            ObjectSerializer::sanitizeForSerialization($this),
            JSON_PRETTY_PRINT
        );
    }

    /**
     * Gets a header-safe presentation of the object
     *
     * @return string
     */
    public function toHeaderValue()
    {
        return json_encode(ObjectSerializer::sanitizeForSerialization($this));
    }
}


