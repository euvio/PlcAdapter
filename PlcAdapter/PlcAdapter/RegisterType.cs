namespace PlcAdapter
{
    public enum RegisterType
    {
        BoolReadOnly,
        SByteReadOnly,
        ByteReadOnly,
        Int16ReadOnly,
        UInt16ReadOnly,
        Int32ReadOnly,
        UInt32ReadOnly,
        Int64ReadOnly,
        UInt64ReadOnly,
        FloatReadOnly,
        DoubleReadOnly,
        BoolReadWrite,
        SByteReadWrite,
        ByteReadWrite,
        Int16ReadWrite,
        UInt16ReadWrite,
        Int32ReadWrite,
        UInt32ReadWrite,
        Int64ReadWrite,
        UInt64ReadWrite,
        FloatReadWrite,
        DoubleReadWrite,

        #region readonly string whose length is 1-100

        String01ReadOnly, String02ReadOnly, String03ReadOnly, String04ReadOnly, String05ReadOnly, String06ReadOnly, String07ReadOnly, String08ReadOnly, String09ReadOnly, String10ReadOnly,
        String11ReadOnly, String12ReadOnly, String13ReadOnly, String14ReadOnly, String15ReadOnly, String16ReadOnly, String17ReadOnly, String18ReadOnly, String19ReadOnly, String20ReadOnly,
        String21ReadOnly, String22ReadOnly, String23ReadOnly, String24ReadOnly, String25ReadOnly, String26ReadOnly, String27ReadOnly, String28ReadOnly, String29ReadOnly, String30ReadOnly,
        String31ReadOnly, String32ReadOnly, String33ReadOnly, String34ReadOnly, String35ReadOnly, String36ReadOnly, String37ReadOnly, String38ReadOnly, String39ReadOnly, String40ReadOnly,
        String41ReadOnly, String42ReadOnly, String43ReadOnly, String44ReadOnly, String45ReadOnly, String46ReadOnly, String47ReadOnly, String48ReadOnly, String49ReadOnly, String50ReadOnly,
        String51ReadOnly, String52ReadOnly, String53ReadOnly, String54ReadOnly, String55ReadOnly, String56ReadOnly, String57ReadOnly, String58ReadOnly, String59ReadOnly, String60ReadOnly,
        String61ReadOnly, String62ReadOnly, String63ReadOnly, String64ReadOnly, String65ReadOnly, String66ReadOnly, String67ReadOnly, String68ReadOnly, String69ReadOnly, String70ReadOnly,
        String71ReadOnly, String72ReadOnly, String73ReadOnly, String74ReadOnly, String75ReadOnly, String76ReadOnly, String77ReadOnly, String78ReadOnly, String79ReadOnly, String80ReadOnly,
        String81ReadOnly, String82ReadOnly, String83ReadOnly, String84ReadOnly, String85ReadOnly, String86ReadOnly, String87ReadOnly, String88ReadOnly, String89ReadOnly, String90ReadOnly,
        String91ReadOnly, String92ReadOnly, String93ReadOnly, String94ReadOnly, String95ReadOnly, String96ReadOnly, String97ReadOnly, String98ReadOnly, String99ReadOnly, String100ReadOnly,

        #endregion readonly string whose length is 1-100

        #region read&write string whose length is 1-100

        String01ReadWrite, String02ReadWrite, String03ReadWrite, String04ReadWrite, String05ReadWrite, String06ReadWrite, String07ReadWrite, String08ReadWrite, String09ReadWrite, String10ReadWrite,
        String11ReadWrite, String12ReadWrite, String13ReadWrite, String14ReadWrite, String15ReadWrite, String16ReadWrite, String17ReadWrite, String18ReadWrite, String19ReadWrite, String20ReadWrite,
        String21ReadWrite, String22ReadWrite, String23ReadWrite, String24ReadWrite, String25ReadWrite, String26ReadWrite, String27ReadWrite, String28ReadWrite, String29ReadWrite, String30ReadWrite,
        String31ReadWrite, String32ReadWrite, String33ReadWrite, String34ReadWrite, String35ReadWrite, String36ReadWrite, String37ReadWrite, String38ReadWrite, String39ReadWrite, String40ReadWrite,
        String41ReadWrite, String42ReadWrite, String43ReadWrite, String44ReadWrite, String45ReadWrite, String46ReadWrite, String47ReadWrite, String48ReadWrite, String49ReadWrite, String50ReadWrite,
        String51ReadWrite, String52ReadWrite, String53ReadWrite, String54ReadWrite, String55ReadWrite, String56ReadWrite, String57ReadWrite, String58ReadWrite, String59ReadWrite, String60ReadWrite,
        String61ReadWrite, String62ReadWrite, String63ReadWrite, String64ReadWrite, String65ReadWrite, String66ReadWrite, String67ReadWrite, String68ReadWrite, String69ReadWrite, String70ReadWrite,
        String71ReadWrite, String72ReadWrite, String73ReadWrite, String74ReadWrite, String75ReadWrite, String76ReadWrite, String77ReadWrite, String78ReadWrite, String79ReadWrite, String80ReadWrite,
        String81ReadWrite, String82ReadWrite, String83ReadWrite, String84ReadWrite, String85ReadWrite, String86ReadWrite, String87ReadWrite, String88ReadWrite, String89ReadWrite, String90ReadWrite,
        String91ReadWrite, String92ReadWrite, String93ReadWrite, String94ReadWrite, String95ReadWrite, String96ReadWrite, String97ReadWrite, String98ReadWrite, String99ReadWrite, String100ReadWrite

        #endregion read&write string whose length is 1-100
    }
}